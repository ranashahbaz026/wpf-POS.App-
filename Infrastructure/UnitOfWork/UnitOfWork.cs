using Infrastructure.Repos;
using Infrastructure.Data.Context;

namespace Domain.Interfaces
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        public ICategoryRepository _CategoryRepository;
        public ICompanyRepository _companyRepository;
        public IProductRepository _ProductRepository;

        private readonly AppDbContext _context;
        public UnitOfWork(AppDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public ICategoryRepository CategoryRepository
        {
            get
            {
                return _CategoryRepository ??= new CategoryRepository(_context);
            }
        }

        //public IInventoryRepository InventoryRepository
        //{
        //    get
        //    {
        //        return _InventoryRepository ??= new InventoryRepository(_context);
        //    }
        //}

        public IProductRepository ProductRepository
        {
            get
            {
                return _ProductRepository ??= new ProductRepository(_context);
            }
        }

        public ICompanyRepository CompanyRepository
        {
            get
            {
                return _companyRepository ??= new CompanyRepository(_context);
            }
        }

        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

    }
}
