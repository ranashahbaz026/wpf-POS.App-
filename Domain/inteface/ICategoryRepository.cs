using BLL.ViewModel;
using Dal.Entities;
using DAL.DB_Models;

namespace BLL.inteface
{
    public interface ICategoryRepository
    {
        public Categories GetCategoryByName(string categoryName);

        //public IEnumerable<SubcategoryVM> GetSubcategories();

    }
}