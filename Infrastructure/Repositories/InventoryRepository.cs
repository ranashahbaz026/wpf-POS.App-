//using Domain.Interfaces;
//using BLL.ViewModel;
 
//  
//using DAL.DB_Models;
//  
//using Microsoft.Data.SqlClient;
//using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Metadata.Internal;
//using Microsoft.Identity.Client;
//using System;
//using System.Collections;
//using System.Collections.Generic;
//using System.Data;
//using System.Data.Common;
//using System.Linq;
//using System.Reflection.Metadata;
//using System.Reflection.PortableExecutable;
//using System.Runtime.InteropServices;
//using System.Text;
//using System.Threading.Tasks;

//namespace Infrastructure.Repos
//{
//    public class InventoryRepository : IInventoryRepository
//    {
//        private readonly AppDbContext _context;

//        public InventoryRepository(AppDbContext context)
//        {
//            this._context = context;
//        }

//        List<InventoryVM> IInventoryRepository.GetInventories()
//        {
//            var results = new List<InventoryVM>();

//            using (var command = _context.Database.GetDbConnection().CreateCommand())
//            {
//                if (command.Connection.State != ConnectionState.Open)
//                    command.Connection.Open();

//                command.CommandText = "Get_Inventories";
//                command.CommandType = CommandType.StoredProcedure;

//                using (var reader = command.ExecuteReader())
//                {
//                    if (reader.HasRows)
//                    {
//                        while (reader.Read())
//                        {
//                            try
//                            {
//                                var product = new Product();
//                                product.Product_Name = reader.GetString(reader.GetOrdinal("Product_Name"));
//                                product.Minimum_Stock_Quantity = reader.GetInt32(reader.GetOrdinal("Minimum_Stock_Quantity"));
//                                product.Category_ID = reader.GetInt32(reader.GetOrdinal("Category_ID"));
//                                if (!isNull(reader, "Unit_ID"))
//                                    product.Unit_ID = reader.GetInt32(reader.GetOrdinal("Unit_ID"));

//                                if (!isNull(reader, "Barcode"))
//                                    product.Barcode = reader.GetString(reader.GetOrdinal("Barcode"));

//                                if (!isNull(reader, "Image"))
//                                    product.Image = reader.GetString(reader.GetOrdinal("Image"));

//                                product.Selling_Price = reader.GetDouble(reader.GetOrdinal("Selling_Price"));

//                                var productWithCategoryAndUnitName = new ProductWithCategoryAndUnitName
//                                {
//                                    CategoryName = reader.GetString(reader.GetOrdinal("Category_Name")),
//                                    UnitName = (isNull(reader, "Unit") ? null : reader.GetString(reader.GetOrdinal("Unit"))),
//                                    Product = product
//                                };

//                                var result = new InventoryVM
//                                {
//                                    Inventory_Id = reader.GetInt32(reader.GetOrdinal("Inventory_Id")),
//                                    ProductID = reader.GetInt32(reader.GetOrdinal("ProductID")),
//                                    Price = reader.GetDouble(reader.GetOrdinal("Price")),
//                                    Quantity = reader.GetDouble(reader.GetOrdinal("Quantity")),
//                                    CreatedAt = (isNull(reader, "CreatedAt") ? null : reader.GetDateTime(reader.GetOrdinal("CreatedAt"))),
//                                    ProductWithCategoryAndUnitName = productWithCategoryAndUnitName
//                                };

//                                results.Add(result);
//                            }
//                            catch (Exception ex) // SHahbaz remove
//                            {

//                            }
//                        }
//                    }
//                }
//            }
//            return results;
//        }


//        public bool isNull(DbDataReader reader, string colName)
//        {
//            var x = reader.GetOrdinal(colName);
//            return reader.IsDBNull(x);
//        }
//    }
//}
