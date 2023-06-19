using Prism.Commands;
using SunClouds.View;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace SunClouds.ViewModel
{
    internal class MainViewModel
    {
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
    public ObservableCollection<string> ComboBoxStart { get; set; }= new ObservableCollection<string>() { "hehe", "haha" };
    public static Uri BackGround {
            get 
            {
                DateTime Date = DateTime.Now;
                if(Date > new DateTime(Date.Year, Date.Month, Date.Day, 0, 0, 0) && Date < new DateTime(Date.Year, Date.Month, Date.Day, 3, 0, 0))
                    return new Uri("../Img/Night.png", UriKind.Relative);
                else if (Date > new DateTime(Date.Year, Date.Month, Date.Day, 12, 0, 0) && Date < new DateTime(Date.Year, Date.Month, Date.Day, 16, 0, 0))
                    return new Uri("../Img/Day.png", UriKind.Relative);
                else
                    return new Uri("../Img/MorningEvening.png", UriKind.Relative);
            }
        }
    
    }
}
