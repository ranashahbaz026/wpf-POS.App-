using Domain.Interfaces;
using BLL.ViewModel;  
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infrastructure.Data.Context;

namespace Infrastructure.Repos
{
    public class CompanyRepository : ICompanyRepository
    {
        private readonly AppDbContext context;

        public CompanyRepository(AppDbContext context)
        {
            this.context = context;
        }

        //public Company GetCompanyByName(string companyName)
        //{
        //    return context.Companies.Where(x => x.CompanyName == companyName).FirstOrDefault();
        //}
         
    }
}
