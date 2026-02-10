using Domain.Interfaces;
using Domain.Entities;
using Infrastructure.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repos
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly AppDbContext context;

        public CategoryRepository(AppDbContext context)
        {
            this.context = context;
        }

        public Categories GetCategoryByName(string categoryName)
        {
            return context.Categories.Where(x=>x.Category_Name == categoryName).FirstOrDefault();
        }

        //public IEnumerable<SubcategoryVM> GetSubcategories()
        //{
        //   var result = from subcategory in context.SubCategories.Where(x=>x.Deleted ==false)
        //                join category in context.Categories
        //                on subcategory.Category_ID equals category.Id
        //                select new SubcategoryVM
        //                {
        //                    ID = subcategory.Id,
        //                    Category_ID = subcategory.Category_ID,
        //                    Subcategory_Name = subcategory.Sub_Category_Name,
        //                    Category_Name = category.Category_Name
        //                };

        //    return result;
        //}
    }
}
