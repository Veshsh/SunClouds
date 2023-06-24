using SunClouds.Model;

using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;
using System.Windows;
namespace SunClouds
{
    /// <summary>
    /// Логика взаимодействия для App.xaml public IHost AppHost { get; init; }
    /// </summary>
    public partial class App : Application
    {
        public IHost AppHost { get; set; }//init сука 

        public App()
        {
            AppHost = Host.CreateDefaultBuilder().ConfigureServices(services =>
            {
                services.AddSingleton<MainWindow, MainWindow>();
                services.AddSingleton<OWM_API, OWM_API>();
            }).Build()!;
        }
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            AppHost.Start();
            AppHost.Services.GetRequiredService<MainWindow>().Show();
        }
    }
}
