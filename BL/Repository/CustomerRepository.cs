//using BLL.inteface;
// 
//  
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace BLL.Repository
//{
//    public class CustomerRepository : ICustomerRepository
//    {
//        private readonly AppDbContext context;

//        public CustomerRepository(AppDbContext context)
//        {
//            this.context = context;
//        }
//        public IEnumerable<Product> GetProductByCustomerId(int id)
//        {
//            return context.Customers.Where(C => C.Id == id).Join(
//                   context.OrderProducts,
//                   C => C.Id,
//                   O => O.Order.CustomerId,
//                   (C, O) => new Product
//                   {
//                       Id = O.Product.Id,
//                       Product_Name = O.Product.Name,
//                       Size = O.Product.Size,

//                       Price = O.Product.Price,
//                       Description = O.Product.Description,


//                   });
//        }
//    }
//}
