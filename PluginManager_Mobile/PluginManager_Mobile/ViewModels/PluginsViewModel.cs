using PluginManager_Mobile.Models;
using PluginManager_Mobile.Services;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using Xamarin.Forms;
using PluginManager_Mobile.Views;
using Xamarin.CommunityToolkit.ObjectModel;

namespace PluginManager_Mobile.ViewModels
{
    public class PluginsViewModel : BaseViewModel
    {
        public ObservableCollection<Plugin> Plugins { get; set; }          
        private readonly IPluginService _pluginService;        
        public AsyncCommand<Plugin> PluginSelected { get; }      
        public AsyncCommand LoadAll { get; }
        public PluginsViewModel()
        {
            Plugins = new ObservableCollection<Plugin>();
            _pluginService = DependencyService.Get<IPluginService>();
            PluginSelected = new AsyncCommand<Plugin>(OnPluginSelected);
            LoadAll = new AsyncCommand(GetAllPlugins);
        }

        private async Task GetAllPlugins()
        {
            //Plugins.Add(new Plugin { name = "test name", category = 0 });
            IsBusy = true;
            Plugins.Clear();
            //await Task.Delay(2000);
            var plugs = await _pluginService.GetAllPlugins();
            foreach (var p in plugs)
            {
                Plugins.Add(p);
            }
            IsBusy = false;
        }

        async Task OnPluginSelected(Plugin plugin)
        {
            if (plugin == null)
                return;
            await Application.Current.MainPage.Navigation.PushAsync(new PluginDetailPage(plugin));
        }
    }
}
