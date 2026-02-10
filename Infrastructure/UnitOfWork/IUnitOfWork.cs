

namespace Domain.Interfaces
{
    public interface IUnitOfWork
    {
        ICategoryRepository CategoryRepository { get; }
        ICompanyRepository CompanyRepository { get; }
        IProductRepository ProductRepository { get; }
        Task SaveAsync();
    }
}
