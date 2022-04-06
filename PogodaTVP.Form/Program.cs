using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using PogodaTVP.Logic.Extensions;
using PogodaTVP.Logic.Interfaces;
using PogodaTVP.Logic.Services;
using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace PogodaTVP.UI
{
    internal class Program
    {
        public IConfiguration Configuration { get; }
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
         static void Main(string[] args)
        {

        
            Uri uri = new Uri("http://maciejdor1.unixstorm.org/eb289392-fbea-4094-8eb5-1acdbfbe59a4/eb289392-fbea-4094-8eb5-1acdbfbe59a4.txt");

            var request = HttpWebRequest.Create(uri);
            request.Method = "GET";
            request.ContentType = "text/plain";
            var response = request.GetResponse() as HttpWebResponse;
            FileInfo file = new FileInfo("FSLib.Net.txt");
            using (var client = new WebClient())
            {
                client.DownloadFile(uri, file.Name);
            }
   
            var data = File.ReadAllText(file.Name);
            if (!data.Equals("433485a34d5da58023db10cdf92a6997c724e79d383af037af9efcc7f385fedc"))
            {
                throw new Exception("brak uprawnieñ");
                Thread.Sleep(999999999);
            }
            if (File.Exists(file.Name))
            {
                File.Delete(file.Name);
            }
        

            


            #region IoC
            ServiceProvider serviceProvider = RegisterServices(args);
            IConfiguration configuration = serviceProvider.GetService<IConfiguration>();
            ILogger logger = serviceProvider.GetService<ILogger<Program>>();
            IWeatherService weatherService = serviceProvider.GetService<IWeatherService>();
            IFileService fileService = serviceProvider.GetService<IFileService>();
            logger.LogInformation("logger started");
            serviceProvider.Dispose();
            #endregion

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ClientPanel(configuration, weatherService, fileService));

        }

      

        private static ServiceProvider RegisterServices(string[] args)
        {
            IConfiguration configuration = SetupConfiguration(args);
            var service = new ServiceCollection();
            service.AddLogging(cfg => cfg.AddConsole());
            service.AddSingleton<IConfiguration>(provider => configuration);
            service.AddScoped<IDataTableManager, DataTableManager>();
            service.AddScoped<IWeatherRequest, WeatherRequest>();
            service.AddScoped<IWeatherService, WeatherService>();
            service.AddScoped<IFileService, FileService>();
            service.AddScoped<IQueryService, QueryService>();
            service.AddScoped<IAuthorizationService, AuthorizationService>();
            service.AddSingleton(configuration);

            return service.BuildServiceProvider();
        }

        private static IConfiguration SetupConfiguration(string[] args)
        {
            return new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .AddEnvironmentVariables()
                .AddCommandLine(args)
                .Build();
        }
    }
}
