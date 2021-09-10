
using PluginManager_Mobile.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PluginManager_Mobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PluginListView : ContentPage
    {        
        private readonly PluginsViewModel _pluginVM;
        public PluginListView()
        {
            _pluginVM = new PluginsViewModel();
            BindingContext = _pluginVM;
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            _pluginVM.IsBusy = true;
            base.OnAppearing();
        }
    }
}