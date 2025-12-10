//  
//   
//using Microsoft.AspNetCore.Identity;
//using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore;

//namespace Dal.Context
//{
//    public class AppDbContext : IdentityDbContext<ApplicationUser>
//    {
//        public DbSet<Product> Products { get; set; }
//        public DbSet<Categories> Categories { get; set; }
//        public DbSet<SubCategories> SubCategories { get; set; }
//        public DbSet<LU_Units> LU_Units { get; set; }
//        public DbSet<Inventory> Inventory { get; set; }

//        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
//        {
//        }

//        protected override void OnModelCreating(ModelBuilder modelBuilder)
//        {
//            modelBuilder.Entity<OrderProduct>().HasKey(p => new { p.OrderId, p.ProductId });
//            base.OnModelCreating(modelBuilder);
//        }
//    }
//}
