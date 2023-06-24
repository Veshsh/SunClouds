using Microsoft.Extensions.DependencyInjection;
using SunClouds.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using Xamarin.Essentials;

namespace SunClouds.ViewModel
{
    internal class SunCloudsViewModel
    {
        public SunCloudsViewModel() {

            OWM_API api = ((App)App.Current).AppHost.Services.GetRequiredService<OWM_API>();
            Cels = Convert.ToInt32(UnitConverters.KelvinToCelsius(api.GetTemperature(0)));
            Humi = api.GetHumidity(0);
            CelsF = Convert.ToInt32(UnitConverters.KelvinToCelsius(api.GetTemperatureFeelsLike(0)));
        }
        public int CelsF { get; set; }
        public int Cels { get; set; }
        public int Max { get; set; }
        public int Min { get; set; }
        public int Pres { get; set; } 
        public int Humi { get; set; }
        public int WindM { get; set; } 
        public int WindC { get; set; } 
        public static Brush Them1 { get; set; } = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#F8C5B4"));
        public static Brush Them2 { get; set; } = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#3D95B9"));
        
    }
}
