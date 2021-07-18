using plugin_manager_mobile.Services;
using plugin_manager_mobile.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace plugin_manager_mobile
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
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
    }
}
