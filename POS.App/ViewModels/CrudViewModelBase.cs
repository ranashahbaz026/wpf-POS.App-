using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;
using System.Windows.Input;

public abstract class CrudViewModelBase<T> : BaseViewModel
{
    public ObservableCollection<T> Items { get; set; }
    public T SelectedItem { get; set; }

    private string _searchText;
    public string SearchText
    {
        get => _searchText;
        set
        {
            _searchText = value;
            OnPropertyChanged();
            OnSearch(_searchText);
        }
    }

    public ICommand AddCommand { get; }
    public ICommand UpdateCommand { get; }
    public ICommand DeleteCommand { get; }

    protected CrudViewModelBase()
    {
        Items = new ObservableCollection<T>();

        AddCommand = new RelayCommand(Add);
        UpdateCommand = new RelayCommand(Update);
        DeleteCommand = new RelayCommand(Delete);
    }

    protected abstract void Add();
    protected abstract void Update();
    protected abstract void Delete();
    protected abstract void OnSearch(string text);
}
