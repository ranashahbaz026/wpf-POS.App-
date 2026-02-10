using BLL.inteface;
using BLL.ViewModel; 
using DAL.DB_Models;
using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly AppDbContext context;

        public ProductRepository(AppDbContext context)
        {
            this.context = context;
        }

        //public List<Prod> GetProducts()
        //{
        //    var query = context.Products
        //               .Where(p => !p.Isactive)
        //               .Select(p => new
        //               {
        //                   Product = p,
        //                   CategoryId = p.CategoryId
        //               })
        //               .ToList() // Force client-side evaluation to get products, their associated category IDs, and unit IDs
        //               .GroupJoin(
        //                   context.Categories,
        //                   product => product.CategoryId,
        //                   category => category.Id,
        //                   (product, categories) => new
        //                   {
        //                       Product = product.Product,
        //                       Categories = categories.DefaultIfEmpty()
        //                   })
        //               .SelectMany(
        //                   joinedData => joinedData.Categories,
        //                   (joinedData, category) => new
        //                   {
        //                       Product = joinedData.Product,
        //                       CategoryName = category != null ? category.Name : null
        //                   })
        //               //.GroupJoin(
        //               //    context.LU_Units,
        //               //    productCategory => productCategory.Product.Unit_ID,
        //               //    unit => unit.Id,
        //               //    (productCategory, units) => new ProductWithCategoryAndUnitName
        //               //    {
        //               //        Product = productCategory.Product,
        //               //        CategoryName = productCategory.CategoryName,
        //               //        UnitName = units.FirstOrDefault()?.Unit
        //               //    })
        //               .ToList();


        //    return query;
        //}
    }
}
