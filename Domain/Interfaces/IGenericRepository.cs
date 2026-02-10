 using Domain.Entities; 

namespace Domain.Interfaces
{
   public interface IGenericRepository<T> where T : BaseEntity
    {
       public Task<IEnumerable<T>> GetAll();
       public Task<T> GetById(int? id);
        public Task<int> Create(T entity);
        public Task<int> Update(T entity);
        public Task Delete(T id); 


    }
}
