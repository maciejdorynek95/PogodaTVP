using PogodaTVP.Core.Models;
using System.Data;

namespace PogodaTVP.Logic.Interfaces
{
    public interface IDataTableManager
    {
        Weather GetWeatherFromDataTable(DataTable dataTable);
        DataTable[] ConvertHTMLTablesToDataTable();
    }
}
