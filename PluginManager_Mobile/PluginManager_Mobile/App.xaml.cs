
using PluginManager_Mobile.Services;
using PluginManager_Mobile.Views;
using Xamarin.Forms;

namespace PluginManager_Mobile
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            DependencyService.Register<IPluginService, PluginService>();
            MainPage = new NavigationPage(new HomePage());
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
