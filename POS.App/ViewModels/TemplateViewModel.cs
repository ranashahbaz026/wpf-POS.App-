using System.Collections.ObjectModel;
using System.Windows.Input;

public class TemplateViewModel : BaseViewModel
{
    public ObservableCollection<ItemModel> Items { get; set; }
    public ItemModel SelectedItem { get; set; }

    private string _searchText;
    public string SearchText
    {
        get => _searchText;
        set
        {
            _searchText = value;
            OnPropertyChanged();
            FilterData();
        }
    }

    public ICommand AddCommand { get; set; }
    public ICommand UpdateCommand { get; set; }
    public ICommand DeleteCommand { get; set; }

    public TemplateViewModel()
    {
        Items = new ObservableCollection<ItemModel>
        {
            new ItemModel{ Id=1, Name="Item A", Price=100 },
            new ItemModel{ Id=2, Name="Item B", Price=150 }
        };

        AddCommand = new RelayCommand(Add);
        UpdateCommand = new RelayCommand(Update);
        DeleteCommand = new RelayCommand(Delete);
    }

    private void Add() { /* open add popup */ }
    private void Update() { /* open update popup */ }
    private void Delete() { /* delete selected */ }

    private void FilterData()
    {
        // TODO: you can implement filter here
    }

    public class ItemModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
    }

}
