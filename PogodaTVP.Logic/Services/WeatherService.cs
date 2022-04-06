using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using PogodaTVP.Core.Enums;
using PogodaTVP.Core.Models;
using PogodaTVP.Core.Models.Cumulus;
using PogodaTVP.Logic.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;

namespace PogodaTVP.Logic.Services
{
    public class WeatherService : IWeatherService
    {
        private readonly ILogger<WeatherService> _logger;
        private readonly IWeatherRequest _weatherRequest;
        private readonly IQueryService _queryService;
        private readonly IAuthorizationService _authorizationService;
        private readonly IFileService _fileService;
        public WeatherService(ILogger<WeatherService> logger,IAuthorizationService authorizationService, IWeatherRequest weatherRequest, IQueryService queryService, IConfiguration configuration, IFileService fileService)
        {
            _logger = logger;
            _weatherRequest = weatherRequest;
            _queryService = queryService;
            _authorizationService = authorizationService;
            _fileService = fileService;
        }
   
        public FileInfo GetWeatherFileFromMeteoService()
        {
    
            try
            {

            
            var authorization = _authorizationService.CreateAuthorizationToken();
            var query = new Query(authorization,QueryData.xml);
            var queryString = _queryService.CreateQueryString(query);
            var request = _weatherRequest.CreateRequestPOST(queryString);
            var response = _weatherRequest.SendRequest(request, queryString);

            var file = _fileService.CreateFileFromHttpResponse(response);
            return _fileService.ExtractFile(file);            
            }
            catch (Exception ex)
            {
                _logger.LogError("Błąd podczas pobierania pliku pogody z serwisu Meteo" + ex.Message + "|" + ex.InnerException);
                throw;
            }
        }

        public WeatherRegion GetWeatherRegion(Meteomax meteomax, WeatherDay weatherDay, WeatherPart weatherPart)
        {
      
            var selectedCityWeatherGroup = new List<WeatherCity>();
            var cities = meteomax.forecastRecords;

            foreach (var city in cities)
            {
                selectedCityWeatherGroup.Add(GetWeatherFromCity(city, weatherDay, weatherPart));
            }

            return new WeatherRegion
            {
                Wersja = weatherDay.ToString(),
                Dzień = cities[1].day[(int)weatherDay].date.ToShortDateString(), // dla opola - bez znaczenia
                hPa = cities[1].day[(int)weatherDay].time[(int)weatherPart].pressureSLP.ToString(), // hpa dla opola
                PogodaMiasto = selectedCityWeatherGroup
            };
        }

   

        private WeatherCity GetWeatherFromCity(meteomaxCity city, WeatherDay weatherDay, WeatherPart weatherPart)
        {
            var weatherCity = new WeatherCity()
            {
                Miasto = city.name,
                Temperatura = city
                    .day[(int)weatherPart]
                    .time[(int)weatherPart]
                    .temp.ToString(),
            };
            if (weatherPart == WeatherPart.Noc)
            {
                weatherCity.SytuacjaPogodowa = WeatherSituation.MapWeatherSituationToAdobeNight(Enum.Parse<CulumbusWeatherSituation>(city.day[(int)weatherDay].time[(int)weatherPart].conditions.ToString()));
            }
            else 
            {
                weatherCity.SytuacjaPogodowa = WeatherSituation.MapWeatherSituationToAdobeDay(Enum.Parse<CulumbusWeatherSituation>(city.day[(int)weatherDay].time[(int)weatherPart].conditions.ToString()));
            }
            return weatherCity;


           
        }

        public Meteomax GetWeatherFromXml(FileInfo file)
        {
            Meteomax weather;
            var xml = new XmlDocument();
                xml.Load(file.FullName);
                xml.RemoveChild(xml.FirstChild);
            var meteomax = FSLib_XmlSerializeExtension.XmlDeserialize<Meteomax>(xml.OuterXml);
            return meteomax;

        }
    }
}
