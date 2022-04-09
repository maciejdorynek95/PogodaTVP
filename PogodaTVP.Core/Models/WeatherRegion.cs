using PogodaTVP.Core.Enums;
using PogodaTVP.Core.Interfaces;
using System.Collections.Generic;

namespace PogodaTVP.Core.Models
{
    public class WeatherRegion : IWeatherWind
    {
        public string Wersja { get; set; } // dzień / noc
        public string Dzień { get; set; } // dziś / jutro
        public string hPa { get; set; }
        public AdobeWeatherWindDirection WiatrKierunek { get; protected set; }
        public List<WeatherCity> PogodaMiasto { get; set; }

        public void SetWeatherDirection(WeatherWindDirection weatherWindDirection)
        {
            switch (weatherWindDirection)
            {
                case WeatherWindDirection.NONE:
                    WiatrKierunek = AdobeWeatherWindDirection.BRAK;
                    break;
                case WeatherWindDirection.S:
                    WiatrKierunek = AdobeWeatherWindDirection.Z_POLUDNIA;
                    break;
                case WeatherWindDirection.SW:
                    WiatrKierunek = AdobeWeatherWindDirection.Z_POLNOCNEGO_ZACHODU;
                    break;
                case WeatherWindDirection.W:
                    WiatrKierunek = AdobeWeatherWindDirection.Z_ZACHODU;
                    break;
                case WeatherWindDirection.NW:
                    WiatrKierunek = AdobeWeatherWindDirection.Z_POLNOCNEGO_ZACHODU;
                    break;
                case WeatherWindDirection.N:
                    WiatrKierunek = AdobeWeatherWindDirection.Z_POLNOCY;
                    break;
                case WeatherWindDirection.NE:
                    WiatrKierunek = AdobeWeatherWindDirection.Z_POLNOCNEGO_WSCHODU;
                    break;
                case WeatherWindDirection.E:
                    WiatrKierunek = AdobeWeatherWindDirection.ZE_WSCHODU;
                    break;
                case WeatherWindDirection.SE:
                    WiatrKierunek = AdobeWeatherWindDirection.Z_POLUDNIOWEGO_WSCHODU;
                    break;
                default:
                    WiatrKierunek = AdobeWeatherWindDirection.BRAK;
                    break;

            }
        }
    }
}
