using Microsoft.Extensions.DependencyInjection;

using System;

using Xamarin.Forms;

namespace WeatherOnRoute
{
    public partial class App : Application
    {
        protected static IServiceProvider ServiceProvider { get; set; }

        public App()
        {
            InitializeComponent();
            SetupServices();

            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }

        void SetupServices()
        {
            var services = new ServiceCollection();

            // Add Services or ViewModels
            // services.AddSingleton<IDataService, SampleDataService>();

            ServiceProvider = services.BuildServiceProvider();
        }

    }
}
