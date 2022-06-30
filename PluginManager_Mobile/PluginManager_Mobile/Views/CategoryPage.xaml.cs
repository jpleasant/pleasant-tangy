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
    public partial class CategoryPage : ContentPage
    {
        private readonly CategoryViewModel _categoryVM;
        public CategoryPage()
        {
            _categoryVM = new CategoryViewModel();
            BindingContext = _categoryVM;
            InitializeComponent();

        }
    }
}