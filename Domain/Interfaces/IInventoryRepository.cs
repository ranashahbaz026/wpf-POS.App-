using BLL.ViewModel;
  

namespace Domain.Interfaces
{
    public interface IInventoryRepository
    {
        public List<InventoryVM> GetInventories ();
    }
}