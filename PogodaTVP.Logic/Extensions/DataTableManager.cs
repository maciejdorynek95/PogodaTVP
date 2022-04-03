using PogodaTVP.Core.Models;
using PogodaTVP.Logic.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text.RegularExpressions;

namespace PogodaTVP.Logic.Extensions
{
    public class DataTableManager : IDataTableManager
    {
        public readonly DataTable dataTable;
        public readonly string Html;

        public DataTableManager(DataTable dataTable)
        {
            this.dataTable = dataTable;
        }

        public DataTableManager(string Html)
        {
            this.Html = Html;
        }

        public Weather GetWeatherFromDataTable(DataTable dataTable)
        {

            var weather = new Weather();
            weather.WeatherPoland = new WeatherRegion()
            {
                Dzień = "Dziś",
                hPa = Convert.ToString(1000),
                Wersja = "Dziś",
            };
            weather.WeatherPoland.PogodaMiasto = new List<WeatherCity>();

          
            foreach (var rw in dataTable.AsEnumerable())
            {

                weather.WeatherPoland.PogodaMiasto.Add(new WeatherCity()
                {
                    Miasto = Convert.ToString(rw[0]),
                    SytuacjaPogodowa = Convert.ToUInt16(rw[1]),
                    Temperatura = Convert.ToString(rw[2])
                });          
                ;
            }

            return weather;
        }

        public DataTable[] ConvertHTMLTablesToDataTable()
        {


            DataTable[] dt = null;
            DataRow dr = null;
            DataColumn dc = null;
            string TableExpression = "<table[^>]*>(.*?)</table>";
            string HeaderExpression = "<th[^>]*>(.*?)</th>";
            string RowExpression = "<tr[^>]*>(.*?)</tr>";
            string ColumnExpression = "<td[^>]*>(.*?)</td>";
            bool HeadersExist = false;
            int iCurrentColumn = 0;
            int iCurrentRow = 0;

            // Get a match for all the tables in the HTML    
            MatchCollection Tables = Regex.Matches(Html, TableExpression, RegexOptions.Multiline | RegexOptions.Singleline | RegexOptions.IgnoreCase);

            // Loop through each table element
            // 
            int table = 0;
            dt = new DataTable[Tables.Count];
            foreach (Match Table in Tables)
            {

                // Reset the current row counter and the header flag    
                iCurrentRow = 0;
                HeadersExist = false;

                // Add a new table to the DataSet    
                dt[table] = new DataTable();

                // Create the relevant amount of columns for this table (use the headers if they exist, otherwise use default names)    
                if (Table.Value.Contains("<th"))
                {
                    // Set the HeadersExist flag    
                    HeadersExist = true;

                    // Get a match for all the rows in the table    
                    MatchCollection Headers = Regex.Matches(Table.Value, HeaderExpression, RegexOptions.Multiline | RegexOptions.Singleline | RegexOptions.IgnoreCase);

                    // Loop through each header element    
                    foreach (Match Header in Headers)
                    {
                        //dt.Columns.Add(Header.Groups(1).ToString);  
                        dt[table].Columns.Add(Header.Groups[1].ToString());

                    }
                }
                else
                {
                    for (int iColumns = 1; iColumns <= Regex.Matches(Regex.Matches(Regex.Matches(Table.Value, TableExpression, RegexOptions.Multiline | RegexOptions.Singleline | RegexOptions.IgnoreCase)[0].ToString(), RowExpression, RegexOptions.Multiline | RegexOptions.Singleline | RegexOptions.IgnoreCase)[0].ToString(), ColumnExpression, RegexOptions.Multiline | RegexOptions.Singleline | RegexOptions.IgnoreCase).Count; iColumns++)
                    {
                        dt[table].Columns.Add("Column " + iColumns);
                    }
                }

                // Get a match for all the rows in the table    
                MatchCollection Rows = Regex.Matches(Table.Value, RowExpression, RegexOptions.Multiline | RegexOptions.Singleline | RegexOptions.IgnoreCase);

                // Loop through each row element    
                foreach (Match Row in Rows)
                {

                    // Only loop through the row if it isn't a header row    
                    if (!(iCurrentRow == 0 & HeadersExist == true))
                    {

                        // Create a new row and reset the current column counter    
                        dr = dt[table].NewRow();
                        iCurrentColumn = 0;

                        // Get a match for all the columns in the row    
                        MatchCollection Columns = Regex.Matches(Row.Value, ColumnExpression, RegexOptions.Multiline | RegexOptions.Singleline | RegexOptions.IgnoreCase);

                        // Loop through each column element    
                        foreach (Match Column in Columns)
                        {

                            DataColumnCollection columns = dt[table].Columns;

                            if (!columns.Contains("Column " + iCurrentColumn))
                            {
                                //Add Columns  
                                dt[table].Columns.Add("Column " + iCurrentColumn);
                            }
                            // Add the value to the DataRow    
                            dr[iCurrentColumn] = Column.Groups[1].ToString();
                            // Increase the current column    
                            iCurrentColumn += 1;

                        }

                        // Add the DataRow to the DataTable    
                        dt[table].Rows.Add(dr);

                    }

                    // Increase the current row counter    
                    iCurrentRow += 1;
                }

                table++; // next table 
            }

            return (dt);

        }

    }

}
