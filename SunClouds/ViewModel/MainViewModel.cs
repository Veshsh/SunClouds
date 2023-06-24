using Prism.Commands;
using SunClouds.View;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Threading;

namespace SunClouds.ViewModel
{
    internal class MainViewModel : INotifyPropertyChanged
    {
        private System.Timers.Timer _renewalTimer = new();
        public static Uri BackGround
        {
            get
            {
                DateTime Date = DateTime.Now;
                if (Date > new DateTime(Date.Year, Date.Month, Date.Day, 0, 0, 0) && Date < new DateTime(Date.Year, Date.Month, Date.Day, 3, 0, 0))
                    return new Uri("../Img/Night.png", UriKind.Relative);
                else if (Date > new DateTime(Date.Year, Date.Month, Date.Day, 12, 0, 0) && Date < new DateTime(Date.Year, Date.Month, Date.Day, 16, 0, 0))
                    return new Uri("../Img/Day.png", UriKind.Relative);
                else
                    return new Uri("../Img/MorningEvening.png", UriKind.Relative);

            }
        }
        public MainViewModel() {
            _renewalTimer.Interval = 1000;
            _renewalTimer.Elapsed += renewalTimer_Elapsed;
            _renewalTimer.Start();
        }
        public DelegateCommand Enter
        {
            get
            {
                return new DelegateCommand(() =>
                {
                    WindowSunClouds windowSunClouds = new WindowSunClouds();
                    windowSunClouds.Show();
                });
            }
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
        public static Brush Them1 { get; set; } = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#F8C5B4"));
        public static Brush Them2 { get; set; } = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#3D95B9"));
        public ObservableCollection<string> ComboBoxStart { get; set; } = new ObservableCollection<string>() { "hehe", "haha" };

       
        private void renewalTimer_Elapsed(object? sender, ElapsedEventArgs e) => OnPropertyChanged(null, nameof(BackGround));

        public event PropertyChangedEventHandler? PropertyChanged;
        public void OnPropertyChanged(object? sender, string propName) => PropertyChanged?.Invoke(this, new(propName));
    }

}