using BLL.ViewModel;
  

namespace BLL.inteface
{
    public interface IInventoryRepository
    {
        public List<InventoryVM> GetInventories ();
    }
}