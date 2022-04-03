using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using PogodaTVP.Core.Models;
using PogodaTVP.Core.Models.Rejdych.Opolszczyzna;
using PogodaTVP.Logic.Extensions;
using PogodaTVP.Logic.Helpers;
using PogodaTVP.Logic.Interfaces;
using PogodaTVP.Logic.Services;
using System.IO;
using System.Text.Json;

namespace PogodaTVP
{
    internal class Program
    {
        const string xmlFilePathRejdych = @"Data\PogodaRejdych\definition.xml";
        const string htmlFilePath = @"Data\htmlPogoda.html";


        static void Main(string[] args)
        { 

            #region IoC
            ServiceProvider serviceProvider = RegisterServices(args);
      
            serviceProvider.Dispose();
            #endregion

          
            var weather = new WeatherRequest();

            var Test = new TestClass(weather);
            Test.weatherAdapterTest();




            //var xmlString = string.Empty;
            //using (StreamReader re = new StreamReader(xmlFilePath))
            //{
            //    xmlString = re.ReadToEnd();

            //}

            //var objectToProcess = XmlHelper.XmlDeserializer<AdobePremiereObjectOpolszczyzna>(xmlFilePathRejdych);
            //System.Console.WriteLine(objectToProcess);


            //var htmltext = File.ReadAllText(htmlFilePath);
            //System.Console.WriteLine(htmltext);


      
            //var DataTableManager = new DataTableManager(htmltext);
            //var dataTable = DataTableManager.ConvertHTMLTablesToDataTable();


            //var Weather = DataTableManager.GetWeatherFromDataTable(dataTable[0]);

            //foreach (var item in Weather.WeatherPoland.PogodaRegion)
            //{
            //    System.Console.WriteLine(item.Miasto + " " + item.Temperatura);
            //}


            
            //var jsonFile = File.ReadAllText(@"Data/PogodaRejdych/definition.json");

            // Root myDeserializedClass = JsonSerializer.Deserialize<Root>(jsonFile);


            //var resultXmlRejdych = XmlHelper.XmlDeserializer<root>(xmlFilePathRejdych);
            

            //var table = ConvertHTMLTablesToDataTable(htmltext);

            //var htmlobject = HtmlHelper.Convert(htmlFilePath);





            //var DataTableManager = new DataTableManager();
            //var result = GetWeatherFromDataTable(table);


            ////var result = PutData(objectToProcess);
            //var jsonString = XmlToJson(xmlString);


        }


        private static root MergeData(root root, WeatherRegion pogoda)
        {


            root.clientControls[0].value[0].strDB.str = "Wersja dzień";
            root.clientControls[1].value[0].strDB.str = "DZIŚ";
            //root.clientControls[2].value[0].strDB.str = pogoda;



            return null;
        }




        private static ServiceProvider RegisterServices(string[] args)
        {
            IConfiguration configuration = SetupConfiguration(args);
            var service = new ServiceCollection();
     
            service.AddScoped<IDataTableManager, DataTableManager>();
            service.AddScoped<IWeatherRequest, WeatherRequest>();
            service.AddScoped<IWeatherService, WeatherService>();

            service.AddSingleton(configuration);

            return service.BuildServiceProvider();
        }

        private static IConfiguration SetupConfiguration(string[] args)
        {
            return new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                //.AddJsonFile("appsettings.json")
                .AddEnvironmentVariables()
                .AddCommandLine(args)
                .Build();
        }

    }
}

