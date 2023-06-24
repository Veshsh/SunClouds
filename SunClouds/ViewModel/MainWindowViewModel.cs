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
            public static Brush Them1 { get; set; } = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#F8C5B4"));
            public static Brush Them2 { get; set; } = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#3D95B9"));
            public string Syty { get; set; } = "Город";
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

            public static Uri WeatherIcon0
            {
                get
                {
                /*                    if ()
                                        return new Uri("", UriKind.Relative);
                                    else if ()
                                        return new Uri("", UriKind.Relative);
                                    else if ()
                                        return new Uri("", UriKind.Relative);
                                    else if ()
                                        return new Uri("", UriKind.Relative);
                                    else
                                        return new Uri("", UriKind.Relative);*/
                return new Uri("../../Img/Icon.png", UriKind.Relative);
            }
            }
            public static Uri WeatherIcon1
            {
                get
                {
                    /*   if ()
                           return new Uri("", UriKind.Relative);
                       else if ()
                           return new Uri("", UriKind.Relative);
                       else if ()
                           return new Uri("", UriKind.Relative);
                       else if ()
                           return new Uri("", UriKind.Relative);
                       else
                           return new Uri("", UriKind.Relative);*/
                    return new Uri("../../Img/Icon.png", UriKind.Relative);
            }
            }
            public static Uri WeatherIcon2
            {
                get
                {
                /* if ()
                     return new Uri("", UriKind.Relative);
                 else if ()
                     return new Uri("", UriKind.Relative);
                 else if ()
                     return new Uri("", UriKind.Relative);
                 else if ()
                     return new Uri("", UriKind.Relative);
                 else
                     return new Uri("", UriKind.Relative);
*/
                return new Uri("../../Img/Icon.png", UriKind.Relative);
            }
            }
            public static Uri WeatherIcon3
        {
            get
            {
                /*  if ()
                      return new Uri("", UriKind.Relative);
                  else if ()
                      return new Uri("", UriKind.Relative);
                  else if ()
                      return new Uri("", UriKind.Relative);
                  else if ()
                      return new Uri("", UriKind.Relative);
                  else
                      return new Uri("", UriKind.Relative);*/
                return new Uri("../../Img/Icon.png", UriKind.Relative);
            }
        }
        public Uri BackGround
        {
            get
            {
                return MainViewModel.BackGround;
            }
            set { BackGround = MainViewModel.BackGround; }
        }

        public DelegateCommand Exit
            {
                get
                {
                    return new DelegateCommand(() =>
                    {
                        Application application = Application.Current;
                        application.Shutdown();
                    });
                }
            }
            public static bool statewindow = false;
            public DelegateCommand Min
            {
                get
                {
                    return new DelegateCommand(() =>
                    {
                        if (!statewindow)
                            Application.Current.MainWindow.WindowState = WindowState.Maximized;
                        else
                            Application.Current.MainWindow.WindowState = WindowState.Normal;
                        statewindow = !statewindow;

                    });
                }
            }
            public DelegateCommand Hinde
            {
                get
                {
                    return new DelegateCommand(() =>
                    {
                        Application.Current.MainWindow.WindowState = WindowState.Minimized;
                    });
                }
            }
        }
    }
