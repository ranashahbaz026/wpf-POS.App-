using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Dal.Entities;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows;

namespace POS.App.ViewModels
{
    public partial class CategoryListViewModel : ObservableObject
    {
        [ObservableProperty]
        private ObservableCollection<Categories> categories;

        [ObservableProperty]
        private Categories selectedCategory;

        public CategoryListViewModel()
        {
            // Designer (Visual Studio XAML preview)
            if (DesignerProperties.GetIsInDesignMode(new DependencyObject()))
            {
                LoadDesignTimeData();
            }
            else
            {
                LoadRuntimeData();
            }
        }

        private void LoadDesignTimeData()
        {
            Categories = new ObservableCollection<Categories>
            {
                new Categories { Id = 1, Category_Name = "Beverages" },
                new Categories { Id = 2, Category_Name = "Snacks" },
                new Categories { Id = 3, Category_Name = "Cosmetics" }
            };
        }

        private void LoadRuntimeData()
        {
            Categories = new ObservableCollection<Categories>
            {
                new Categories { Id = 1, Category_Name = "Beverages" },
                new Categories { Id = 2, Category_Name = "Snacks" },
                new Categories { Id = 3, Category_Name = "Cosmetics" }
            };


            //    // 🔥 Replace with your DAL/BBL method
            //    // Example from your SQL server
            //    var listFromDb = new List<Category>
            //    {
            //        new Category { Id = 1, Name = "Drinks" },
            //        new Category { Id = 2, Name = "Chocolates" }
            //    };

            //    Categories = new ObservableCollection<Category>(listFromDb);
        }

        // Commands
        [RelayCommand]
        private void Add()
        {
            MessageBox.Show("Add clicked");
        }

        [RelayCommand]
        private void Edit()
        {
            if (SelectedCategory == null)
            {
                MessageBox.Show("Select a category first");
                return;
            }
            MessageBox.Show($"Edit {SelectedCategory.Category_Name}");
        }

        [RelayCommand]
        private void Delete()
        {
            if (SelectedCategory == null)
            {
                MessageBox.Show("Select a category first");
                return;
            }
            MessageBox.Show($"Delete {SelectedCategory.Category_Name}");
        }
    }
     
}