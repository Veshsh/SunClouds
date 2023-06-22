using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace end
{
    /// <summary>
    /// Логика взаимодействия для page_day.xaml
    /// </summary>
    public partial class page_day : Page
    {
        public string cit_name_main { get; set; } = "Гиперборея";
        public string cit_name_fav { get; set; } = "Гиперборея";
        public string panel_color { get; set; } = "#CC4BAFD7";
        public string bg_panel_color { get; set; } = "#CCFAADB6";
        public string cit_coord { get; set; } = "90 ° 00 ′ 00 ″ .Долготы не имеет, так как является точкой схождения всех меридианов";
        public page_day()
        {
            InitializeComponent();
        }
    }
}
