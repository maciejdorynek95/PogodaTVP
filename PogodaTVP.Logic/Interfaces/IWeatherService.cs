using PogodaTVP.Core.Enums;
using PogodaTVP.Core.Models;
using PogodaTVP.Core.Models.Cumulus;

namespace PogodaTVP.Logic.Interfaces
{
    public interface IWeatherService
    {
        WeatherRegion GetWeather(WeatherDay weatherDay, WeatherPart weatherPart);
    }
}
