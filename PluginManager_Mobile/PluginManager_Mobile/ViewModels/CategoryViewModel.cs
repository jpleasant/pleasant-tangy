using PluginManager_Mobile.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.CommunityToolkit.ObjectModel;

namespace PluginManager_Mobile.ViewModels
{
    public class CategoryViewModel : BaseViewModel
    {
        public bool IsActive { get; set; }
        public AsyncCommand<Category> CategorySelected { get; }

        public CategoryViewModel()
        {
            IsActive = false;
            CategorySelected = new AsyncCommand<Category>(OnCategorySelected);
        }
        async Task OnCategorySelected(Category c)
        {
            
        }
    }
}
