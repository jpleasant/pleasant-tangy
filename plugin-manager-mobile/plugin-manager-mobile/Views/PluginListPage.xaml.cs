using Newtonsoft.Json;
using plugin_manager_mobile.Services;
using plugin_manager_mobile.ViewModels;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace plugin_manager_mobile.Views
{

    public partial class PluginListPage : ContentPage
{
        private HttpClient _client = new HttpClient();
        PluginsViewModel _pluginsVM;

        public PluginListPage()
        {
            
            try
            {

                InitializeComponent();
                //BindingContext = _pluginsVM = new PluginsViewModel();
               //Task.Run(async()=> await _pluginsVM.GetAllPlugins());
                
            }
            catch(Exception e)
            {
                Debug.WriteLine(e.Message);
            }
        }

    async void Handle_ItemTapped(object sender, ItemTappedEventArgs e)
    {
        if (e.Item == null)
            return;

        await DisplayAlert("Item Tapped", "An item was tapped.", "OK");

        //Deselect Item
        ((ListView)sender).SelectedItem = null;
    }

        protected override async void OnAppearing()
        {
            var content = await _client.GetStringAsync("https://jsonplaceholder.typicode.com/todos/1");
            var response = content;
            base.OnAppearing();
        }
    }
}
