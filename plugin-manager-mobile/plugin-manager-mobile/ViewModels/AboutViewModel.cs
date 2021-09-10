using plugin_manager_mobile.Services;
using System;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace plugin_manager_mobile.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        private readonly IPluginService _pluginService;
        public AboutViewModel()
        {
            IPluginService _pluginService = DependencyService.Get<IPluginService>();
            Title = "About";
            //OpenWebCommand = new Command(async () => await Browser.OpenAsync("https://aka.ms/xamarin-quickstart"));
            //OpenWebCommand = new Command(async () => await Browser.OpenAsync("http://10.0.2.2:6200/api/plugins"));
            OpenWebCommand = new Command(async () => _pluginService.GetAllPlugins());
        }

        public ICommand OpenWebCommand { get; }
    }
}