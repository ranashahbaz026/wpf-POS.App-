
namespace Domain.Interfaces
{
   public interface IOrderProductRepository
    {
        public Task<int> Create(int ProductId, int OrderId);
        //public Task<List<Product>> GetProduct(int OrderId);
    }
}
