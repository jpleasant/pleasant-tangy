using plugin_manager_mobile.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace plugin_manager_mobile.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}