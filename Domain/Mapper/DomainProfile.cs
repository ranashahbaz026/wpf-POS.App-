using AutoMapper;
using BLL.ViewModel;
using Dal.Entities;
using DAL.DB_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Mapper
{
   public class DomainProfile:Profile
    {
        public DomainProfile() {
            //CreateMap<Customer, CustomerVM>().ReverseMap();
            //CreateMap<Order, OrderVM>().ReverseMap();
            //CreateMap<Product, ProductVM>().ReverseMap();
            //CreateMap<Expense, ExpenseVM>().ReverseMap();
            CreateMap<Categories, CategoryVM>().ReverseMap();
            //CreateMap<Company, CompanyVM>().ReverseMap();
            //CreateMap<LU_Units, LU_UnitsVM>().ReverseMap();
            //CreateMap<Inventory, InventoryVM>().ReverseMap();
            //CreateMap<Inventory, CreateInventoryVM>().ReverseMap();
            //CreateMap<SubCategories, SubcategoryVM>().ReverseMap();
            //CreateMap<SubCategories, UpdateSubcategoryVM>().ReverseMap();
            //CreateMap<SubCategories, CreateSubcategoryVM>().ReverseMap();

        }
    }
}
