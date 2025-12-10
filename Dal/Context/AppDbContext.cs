using System;
using System.Collections.Generic;
using Dal.Entities;
using Microsoft.EntityFrameworkCore;

namespace DAL.DB_Models;

public partial class AppDbContext : DbContext
{
    public AppDbContext()
    {
    }

    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Categories> Categories { get; set; }
     
}
