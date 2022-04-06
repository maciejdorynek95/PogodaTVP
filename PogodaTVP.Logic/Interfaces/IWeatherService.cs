using PogodaTVP.Core.Enums;
using PogodaTVP.Core.Models;
using PogodaTVP.Core.Models.Cumulus;
using System.IO;

namespace PogodaTVP.Logic.Interfaces
{
    public interface IWeatherService
    {
        FileInfo GetWeatherFileFromMeteoService();
        Meteomax GetWeatherFromXml(FileInfo file);
        WeatherRegion GetWeatherRegion(Meteomax meteomax, WeatherDay weatherDay, WeatherPart weatherPart);
    }
}
