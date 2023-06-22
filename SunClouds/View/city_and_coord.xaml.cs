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

namespace end.View
{
    /// <summary>
    /// Interaction logic for city_and_coord.xaml
    /// </summary>
    public partial class city_and_coord : UserControl
    {
        public string UsEl_panel_color { get; set; } = "#CC4BAFD7";
        public string UsEl_bg_panel_color { get; set; } = "#FF3281A1";
        public city_and_coord()
        {
            InitializeComponent();
        }
    }
}
