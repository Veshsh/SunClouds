using SunClouds.View.WindowSunCloudsPage;
using SunClouds.ViewModel;
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
using System.Windows.Shapes;

namespace SunClouds.View
{
    /// <summary>
    /// Логика взаимодействия для WindowSunClouds.xaml
    /// </summary>
    public partial class WindowSunClouds : Window
    {
        public WindowSunClouds()
        {
            InitializeComponent();
            PageFrame.Content = new MainPage();
            DataContext = new MainWindowViewModel();
        }

        private void GoMainPage(object sender, RoutedEventArgs e)
        {
            PageFrame.Content = new MainPage();
        }

        private void GoSettingsPage(object sender, RoutedEventArgs e)
        {
            PageFrame.Content = new SettingsPage();
        }
    }
}
