using Prism.Commands;
using SunClouds.View;
using SunClouds.View.WindowSunCloudsPage;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace SunClouds.ViewModel
{
    internal class MainWindowViewModel
    {
        public int Celsius0 { get; set; } = 11;
        public int Feel0 { get; set; } = 11;
        public string WeatherStatus0 { get; set; } = "НЕ Ясно.";
        public int Celsius1 { get; set; } = 11;
        public int Feel1 { get; set; } = 11;
        public string WeatherStatus1 { get; set; } = "Ясно.";
        public int Celsius2 { get; set; } = 11;
        public int Feel2 { get; set; } = 11;
        public string WeatherStatus2 { get; set; } = "Ясно.";
        public int Celsius3 { get; set; } = 11;
        public int Feel3 { get; set; } = 11;
        public string WeatherStatus3 { get; set; } = "Ясно.";
        public string Time1 { get; set; } = "11:11";
        public string Time2 { get; set; } = "22:22";
        public string Time3 { get; set; } = "33:33";
    }
}
