using PogodaTVP.Core.Enums;
using PogodaTVP.Core.Models;
using System;
using System.Windows.Forms;

namespace PogodaTVP.UI.Controls
{
    public partial class CityWeather : UserControl
    {
        public CityWeather()
        {
            InitializeComponent();
            comboBox1_SytuacjaPogodowa.DisplayMember = "Key";
            comboBox1_SytuacjaPogodowa.ValueMember = "Value";
            comboBox1_SytuacjaPogodowa.DataSource = Enum.GetValues(typeof(AdobeWeatherSituation));

        }
        public CityWeather(WeatherCity city,WeatherRegion weatherRegion)
        {
            InitializeComponent();
            comboBox1_SytuacjaPogodowa.DisplayMember = "Key";
            comboBox1_SytuacjaPogodowa.ValueMember = "Value";
            comboBox1_SytuacjaPogodowa.DataSource = Enum.GetValues(typeof(AdobeWeatherSituation));
            label1_City.Text = city.Miasto;
            dateTimePicker1_Data.Value = Convert.ToDateTime(weatherRegion.Dzień);
            textBox3_Pressure.Text = weatherRegion.hPa;
            textBox2_temp.Text = city.Temperatura;
            comboBox1_SytuacjaPogodowa.SelectedItem = city.SytuacjaPogodowa;
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
