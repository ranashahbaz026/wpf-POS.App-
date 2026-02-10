//using Domain.Interfaces;
// 
//  
//using Microsoft.EntityFrameworkCore;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Infrastructure.Repos
//{
//    public class OrderProductRepository : IOrderProductRepository
//    {
//        private readonly AppDbContext context;

//        public OrderProductRepository(AppDbContext context)
//        {
//            this.context = context;
//        }

//        public async Task<int> Create(int ProductId, int OrderId)
//        {
//            OrderProduct product = new OrderProduct()
//            {
//                OrderId = OrderId,
//                ProductId = ProductId,
//            };
//            await context.OrderProducts.AddAsync(product);
//            return await context.SaveChangesAsync();
//        }

//        public async Task<List<Product>> GetProduct(int OrderId)
//        {


//            var result = await context.OrderProducts.Where(o => o.OrderId == OrderId).ToListAsync();
//            List<Product> productNames = new List<Product>();
//            foreach (var item in result)
//            {

//                var data = await context.Products.FirstOrDefaultAsync(p => p.Id == item.ProductId);
//                productNames.Add(data);
//            }
//            return productNames;
//        }
//    }
//}
