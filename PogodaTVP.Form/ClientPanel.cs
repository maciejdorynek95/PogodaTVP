using Microsoft.Extensions.Configuration;
using PogodaTVP.Core.Enums;
using PogodaTVP.Logic.Interfaces;
using PogodaTVP.UI.Controls;
using PogodaTVP.UI.ViewModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PogodaTVP.UI
{
    public partial class ClientPanel : Form
    {
        private readonly IConfiguration _configuration;
        private readonly IWeatherService _weatherService;
        private readonly IFileService _fileService;

        public ClientPanel(IConfiguration configuration, IWeatherService weatherService, IFileService fileService)
        {
            _weatherService = weatherService;
            _configuration = configuration;
            _fileService = fileService;
            InitializeComponent();
        }



        private void button1_Click_PobierzPogode(object sender, EventArgs e)
        {
            var listDays = new List<WeatherDay>();
            var listParts = new List<WeatherPart>();
            var checkedListBoxDays = checkedListBox_Days.CheckedItems;
            var checkedListBoxWeatherParts = checkedListBox_WeatherParts.CheckedItems;

            foreach (string item in checkedListBoxDays)
            {
                var enumName = item.Replace(" ", "");
                Console.WriteLine(enumName);
                listDays.Add(Enum.Parse<WeatherDay>(enumName, true));
            }

            foreach (string item in checkedListBoxWeatherParts)
            {
                var enumName = item.Replace(" ", "");
                Console.WriteLine(enumName);
                listParts.Add(Enum.Parse<WeatherPart>(enumName, true));
            }


            var controls = CreateWeatherUserControl(listDays, listParts);

            foreach (var control in controls)
            {
                control.control.CreateControl();

                switch (control.weatherPart)
                {
                    case WeatherPart.Noc:
                        addControlToFlowLayoutPanel(flowLayoutPanel_OpolszczyznaNoc, control.control);
                        break;
                    case WeatherPart.PrzedPoludniem:
                        addControlToFlowLayoutPanel(flowLayoutPanel_OpolszczyznaDzien_Przed_Poludniem, control.control);
                        break;
                    case WeatherPart.PoPoludniu:
                        addControlToFlowLayoutPanel(flowLayoutPanel_OpolszczyznaDzien_Po_Poludniu, control.control);
                        break;
                    default:
                        break;
                }


            }


        }


        private void addControlToFlowLayoutPanel(FlowLayoutPanel flowLayoutPanel, Control control)
        {
            flowLayoutPanel.Controls.Add(control);
        }
        public IEnumerable<WeatherControlModel> CreateWeatherUserControl(List<WeatherDay> weatherDays, List<WeatherPart> weatherParts)
        {

            foreach (var weatherDay in weatherDays)
            {

                foreach (var weatherPart in weatherParts)
                {
                    var weather = _weatherService.GetWeather(weatherDay, weatherPart);
                    foreach (var miasto in weather.PogodaMiasto)
                    {
                        var box = new CityWeather();
                        box.label1_City.Text = miasto.Miasto;
                        box.dateTimePicker1_Data.Value = Convert.ToDateTime(weather.Dzień);
                        box.textBox3_Pressure.Text = weather.hPa;
                        box.textBox2_temp.Text = miasto.Temperatura;

                        box.comboBox1_SytuacjaPogodowa.DisplayMember = "Key";
                        box.comboBox1_SytuacjaPogodowa.ValueMember = "Value";
                        yield return new WeatherControlModel(box, weatherDay, weatherPart);
                    }
                }
            }
        }

        public async void button_GenerateAdobe_Click(object sender, EventArgs e)
        {
            string jsonData = null;
            FileInfo adobeFile = null;
            FileInfo pathToOpolszczyznaNocTemplate = new FileInfo(@"..\..\..\..\PogodaTVP\Data\PogodaRejdych\OPOLSZCZYZNA_NOC\definition.json");
            FileInfo pathToOpolszczyznaDzienTemplate = new FileInfo(@"..\..\..\..\PogodaTVP\Data\PogodaRejdych\OPOLSZCZYZNA_DZIEN\definition.json");        
            DirectoryInfo rootPathWeather = new DirectoryInfo(@"..\..\..\..\PogodaTVP\Data\GeneratedAdobeWeather\");
            FileInfo outDirectory = null;
            FileInfo fileName = new FileInfo("definition.json");

            if (flowLayoutPanel_OpolszczyznaNoc.Controls.Count > 0)
            {
                jsonData = File.ReadAllText(pathToOpolszczyznaNocTemplate.FullName);
                outDirectory = CreateNewDirectoryByState(rootPathWeather, "OPOLSZCZYZNA_NOC", fileName);
                adobeFile = GenerateAdobeFile(outDirectory, jsonData, flowLayoutPanel_OpolszczyznaNoc.Controls);


                // await MoveFile(adobeFile, pathToAdobe);
            }

            if (flowLayoutPanel_OpolszczyznaDzien_Przed_Poludniem.Controls.Count > 0)
            {
                jsonData = File.ReadAllText(pathToOpolszczyznaDzienTemplate.FullName);
                outDirectory = CreateNewDirectoryByState(rootPathWeather, "OPOLSZCZYZNA_DZIEN", fileName);
                adobeFile = GenerateAdobeFile(outDirectory, jsonData, flowLayoutPanel_OpolszczyznaDzien_Przed_Poludniem.Controls) ;
               // await MoveFile(adobeFile, pathToAdobe);
            }

            if (flowLayoutPanel_OpolszczyznaDzien_Po_Poludniu.Controls.Count > 0)
            {
                jsonData = File.ReadAllText(pathToOpolszczyznaDzienTemplate.FullName);
                outDirectory = CreateNewDirectoryByState(rootPathWeather, "OPOLSZCZYZNA_DZIEN", fileName);
                adobeFile = GenerateAdobeFile(outDirectory, jsonData, flowLayoutPanel_OpolszczyznaDzien_Po_Poludniu.Controls);
              //  await MoveFile(adobeFile, pathToAdobe);
            }

           
        }

        private FileInfo CreateNewDirectoryByState(DirectoryInfo oldDirectory, string state, FileInfo fileName )
        {
            return new FileInfo($@"{oldDirectory.FullName}\{state}\{fileName.Name}");
        }

        private async Task<FileInfo> MoveFile(FileInfo fileToMove,DirectoryInfo pathToMove)
        {
            fileToMove.MoveTo(pathToMove.FullName,true);
            return await Task.FromResult(new FileInfo(@$"{pathToMove.FullName}\{fileToMove.Name}" ));
        }

        private bool SaveToTargetFolder(string json,FileInfo targetFile)
        {
            if (!targetFile.Directory.Exists)
            {
                Directory.CreateDirectory(targetFile.Directory.FullName);
            }
            
                File.Create(targetFile.FullName).Close();
                
            

            File.WriteAllText(targetFile.FullName, json);
            if (targetFile.Exists)
            {
                return true;
            }
            throw new Exception("Failed when saved filed to Target folder");
        }


        private FileInfo GenerateAdobeFile(FileInfo fileJson, string jsonData, Control.ControlCollection controls)
        {
            // mapowanie
            var json = MapCitiesToAdobe(jsonData, controls);
            // zapisanie do folderu wysjciowego
            SaveToTargetFolder(json, fileJson);
            // zip folderu wyjsciowego
            var zippedFile = _fileService.ZippFile(fileJson); 
            return _fileService.ChangeFileExtensionToMogrt(zippedFile); // adobe czyta .mogrt            


        }
    
       
     
        public string ReplaceGuidsToTemperatureInAdobeJsonFile(string jsonString, string miasto, int temp)
        {

            switch (miasto) // all guids are implemented in template
            {
                case "NAMYSLOW":
                    return jsonString.Replace("b1d6477b-594e-4948-929d-7440a1b2f3b8", temp.ToString());

                case "KLUCZBORK":
                    return jsonString.Replace("73c9dcda-d8af-439c-b23d-a2d8188fbf28", temp.ToString());

                case "OLESNO":
                    return jsonString.Replace("b5ea6d6f-1435-4de7-95a3-0d150d0ee518", temp.ToString());
                    
                case "BRZEG":
                    return jsonString.Replace("16300f80-af26-48aa-87df-5d022360c2fc", temp.ToString());
                   
                case "OPOLE":
                    return jsonString.Replace("82eddb7c-47fa-4379-9b18-ed50e2a8112f", temp.ToString());
                   
                case "STRZELCE":
                    return jsonString.Replace("7de5b7e5-f87d-40e2-bdc3-79962c4f4c0b", temp.ToString());
                    
                case "NYSA":
                    return jsonString.Replace("fc478039-f0cf-4ff2-977c-df63f55f2f8d", temp.ToString());
                    
                case "KRAPKOWICE":
                    return jsonString.Replace("2733d7aa-f5eb-4aaf-9304-32445346714d", temp.ToString());
                   
                case "KEDZIERZYN":
                    return jsonString.Replace("0977a584-7974-48ef-842b-8d1cdb5b3a79", temp.ToString());
                   
                case "PRUDNIK":
                    return jsonString.Replace("f6ab2e23-5c4d-475b-94c0-f555dcd601f4", temp.ToString());
                   
                case "GLUBCZYCE":
                    return jsonString.Replace("b44f58ef-f741-4e15-8c63-377255196f84", temp.ToString());
                   
                default:
                    return jsonString;
            }



        }


        private string MapCitiesToAdobe(string jsonData, Control.ControlCollection controls)
        {
            foreach (CityWeather control in controls)
            {
                var miasto = control.label1_City.Text.ToUpper();

                if (miasto.Equals("KĘDZIERZYN-KOŹLE"))
                {
                    miasto = miasto.Replace("KĘDZIERZYN-KOŹLE", "KEDZIERZYN");
                }

                if (miasto.Equals("NAMYSŁÓW"))
                {
                    miasto = miasto.Replace("NAMYSŁÓW", "NAMYSLOW");
                }

                if (miasto.Equals("STRZELCE OPOLSKIE"))
                {
                    miasto = miasto.Replace("STRZELCE OPOLSKIE", "STRZELCE");
                }

                if (miasto.Equals("GŁUBCZYCE"))
                {
                    miasto = miasto.Replace("GŁUBCZYCE", "GLUBCZYCE");
                }

                jsonData = ReplaceGuidsToTemperatureInAdobeJsonFile(jsonData, miasto, Convert.ToInt16(control.textBox2_temp.Text));
            
            }
            return jsonData;
        }
    }
}
