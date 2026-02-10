using Domain.Interfaces; 
using Entities;
using Infrastructure.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repos
{
    public class GenericRepository<T> : IGenericRepository<T> where T : SoftDeletedEntity

    {
        public AppDbContext Context { get; }
        public GenericRepository(AppDbContext context)
        {
            Context = context;
        }

        public async Task<int> Create(T entity)
        {
            //entity.CreatedAt = DateTime.Now;
            await Context.Set<T>().AddAsync(entity);
            return await Context.SaveChangesAsync();
        }

        //public async Task<int> Delete(T item)
        //{
        //     Context.Set<T>().Remove(item);
        //    return await Context.SaveChangesAsync();
        //}

        public virtual async Task Delete(T obj)
        {
            SoftDelete(obj);
        }

        private async Task<int> SoftDelete(T obj)
        {
            obj.Deleted = false;
            obj.DeletedAt = DateTime.Now;
            Context.Set<T>().Update(obj);
            return await Context.SaveChangesAsync();
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            return await Context.Set<T>().Where(x => x.Deleted == false).ToListAsync();
        }

        public async Task<T> GetById(int? id)
        {
            //if (typeof(T)==typeof(Order)) {
            //  Order result = Context.Orders.Where(o => o.Id == id).Include(o => o.Customer).FirstOrDefault();
            //    return (T)Convert.ChangeType(result, typeof(T));
            //}

            //if (typeof(T) == typeof(Product))
            //{
            //    Product result = Context.Products.Where(o => o.Id == id).FirstOrDefault();
            //    return (T)Convert.ChangeType(result, typeof(T));
            //}

            return await Context.Set<T>().FindAsync(id);
        }

        public async Task<int> Update(T entity)
        {
            entity.UpdatedAt = DateTime.Now;
            Context.Set<T>().Update(entity);
            return await Context.SaveChangesAsync();
        }

    }
}
