using PogodaTVP.Core.Enums;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PogodaTVP.UI.ViewModel
{
    public class WeatherControlModel
    {
        public List<Control> controls { get; set; }
        public WeatherDay weatherDay { get; set; }
        public WeatherPart weatherPart { get; set; }

        public WeatherControlModel(List<Control> controls, WeatherDay weatherDay, WeatherPart weatherPart)
        {
            this.controls = controls;
            this.weatherDay = weatherDay;
            this.weatherPart = weatherPart;
            
        }

    }

   
}
