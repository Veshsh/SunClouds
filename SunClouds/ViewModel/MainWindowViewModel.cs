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
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace SunClouds.ViewModel
{
    internal class MainWindowViewModel
    {
        public Uri BackGround
        {
            get
            {
                return MainViewModel.BackGround;
            }
        }
    }
}
