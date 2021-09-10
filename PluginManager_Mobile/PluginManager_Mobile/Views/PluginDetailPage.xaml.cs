using PluginManager_Mobile.Models;
using PluginManager_Mobile.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PluginManager_Mobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PluginDetailPage : ContentPage
    {
        public PluginDetailPage(Plugin plugin)
        {
            var vm = new PluginDetailViewModel();
            vm.Detail = plugin;
            BindingContext = vm;
            InitializeComponent();
        }
    }
}