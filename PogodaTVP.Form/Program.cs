using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using PogodaTVP.Logic.Extensions;
using PogodaTVP.Logic.Interfaces;
using PogodaTVP.Logic.Services;
using System;
using System.IO;
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
