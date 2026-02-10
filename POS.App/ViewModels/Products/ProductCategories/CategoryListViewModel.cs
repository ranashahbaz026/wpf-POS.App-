using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Dal.Entities;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows;

namespace POS.App.ViewModels
{
    //public partial class CategoryListViewModel : ObservableObject
    //{
    //    [ObservableProperty]
    //    private ObservableCollection<Categories> categories;

    //    [ObservableProperty]
    //    private Categories selectedCategory;

    public partial class CategoryListViewModel : CrudViewModelBase<Categories>
    {
        public CategoryListViewModel()
        {
            Items.Add(new Categories { Id = 1, Category_Name = "Tea" });
            Items.Add(new Categories { Id = 2, Category_Name = "Coffee" });
        }

        protected override void Add()
        {
            // Open Add Product popup
        }

        protected override void Update()
        {
            // Update selected product 
        }

        protected override void Delete()
        {
            // Delete selected product
        }

        protected override void OnSearch(string text)
        {
            // Filter product list
        }
    }
}