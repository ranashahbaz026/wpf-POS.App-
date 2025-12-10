
using DAL.DB_Models;
using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.inteface
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
