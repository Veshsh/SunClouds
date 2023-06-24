using Prism.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace SunClouds.ViewModel
{
    internal class SettingsViewModel
    {
        public static Brush Them1 { get; set; } = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#F8C5B4"));
        public static Brush Them2 { get; set; } = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#3D95B9"));
        public string SytyAdd { get; set; } = "Название города";
        public string cit_name_main { get; set; } = "Гиперборея";
        public string cit_name_fav { get; set; } = "Гиперборея";
        public string cit_coord { get; set; } = "90 ° 00 ′ 00 ″ .Долготы не имеет, так как является точкой схождения всех меридианов";
        public DelegateCommand SaveSetings
        {
            get
            {
                return new DelegateCommand(() =>
                {
                    MessageBox.Show("a");
                });
            }
        }
    }
}
