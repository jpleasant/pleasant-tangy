using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using plugin_manager_mobile.Models;
using plugin_manager_mobile.Services;
using Xamarin.Forms;

namespace plugin_manager_mobile.ViewModels
{
    public class PluginsViewModel : BaseViewModel
    {
        public ObservableCollection<Plugin> Plugins { get; set; }
        public Command LoadPluginsCommand { get; }
        private readonly IPluginService _pluginService;
        public PluginsViewModel()
        {
            Plugins = new ObservableCollection<Plugin>();
            _pluginService = DependencyService.Get<IPluginService>();            
        }

        public async Task GetAllPlugins()
        {
            var plugs =  await _pluginService.GetAllPlugins();
            foreach(var p in plugs)
            {
                Plugins.Add(p);
            }
        }
    }
}
