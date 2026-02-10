  
  
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.ViewModel
{
    public class InventoryAndLookUpsVM
    {
        public List<InventoryVM> inventories { get; set; }
        public List<CategoryVM> LU_Categories { get; set; }
        //public List<LU_Units> LU_Units { get; set; }
    }

    public class InventoryVM
    {
        public int Inventory_Id { get; set; }
        public int ProductID { get; set; }
        public double Quantity { get; set; }
        public double Price { get; set; }
        public DateTime? CreatedAt { get; set; }
        //public ProductWithCategoryAndUnitName ProductWithCategoryAndUnitName { get; set; }

    }
    
    public class CreateInventoryVM
    {
        public int ProductID { get; set; }
        public double Quantity { get; set; }
        public double Price { get; set; }
        public double Sell_Price { get; set; }

    }
}
