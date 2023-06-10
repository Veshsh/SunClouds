using Prism.Commands;
using SunClouds.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
