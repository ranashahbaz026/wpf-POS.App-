using CommunityToolkit.Mvvm.Input;
using POS.App.ViewModels;
using System.Windows.Input;

public class MainWindowViewModel : BaseViewModel
{
    // Current displayed view
    private object _currentView;
    public object CurrentView
    {
        get => _currentView;
        set { _currentView = value; OnPropertyChanged(); }
    }

    public ICommand ShowCategoriesCommand { get; }

    public MainWindowViewModel()
    {
        // default screen
        //CurrentView = new DashboardViewModel(); // or null
        CurrentView = null; // or null

        ShowCategoriesCommand = new RelayCommand(ShowCategories);
    }

    private void ShowCategories()
    {
        CurrentView = new CategoryListViewModel();
    }
}
