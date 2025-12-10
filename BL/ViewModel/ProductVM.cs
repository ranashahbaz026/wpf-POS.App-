

using DAL.DB_Models;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.ViewModel
{
    public class ProductVM
    {
		[Key]
		[Column("ID")]
		public long Id { get; set; }

		[StringLength(100)]
		[Unicode(false)]
		public string ItemCode { get; set; } = null!;

		[StringLength(100)]
		[Unicode(false)]
		public string? ItemName { get; set; }

		[Column(TypeName = "decimal(18, 2)")]
		public decimal? PurchasePrice { get; set; }

		[Column(TypeName = "decimal(18, 2)")]
		public decimal? PurchaseDis { get; set; }

		[Column(TypeName = "decimal(18, 2)")]
		public decimal? SalePrice { get; set; }

		[Column(TypeName = "decimal(18, 2)")]
		public decimal? SaleDis { get; set; }

		[Column("CompanyID")]
		public long? CompanyId { get; set; }

		[Column(TypeName = "decimal(18, 2)")]
		public decimal? Cost { get; set; }

		[Column(TypeName = "decimal(18, 2)")]
		public decimal? QtyBalance { get; set; }

		[Column(TypeName = "decimal(18, 2)")]
		public decimal? QtyBonus { get; set; }

		[Column("ISActive")]
		public bool Isactive { get; set; }

		[Unicode(false)]
		public string? Remarks { get; set; }

		[Column("UOM")]
		[StringLength(20)]
		[Unicode(false)]
		public string? Uom { get; set; }

		public int? UomDetail { get; set; }

		[Column("LocationID")]
		public long? LocationId { get; set; }

		[StringLength(500)]
		[Unicode(false)]
		public string? Disease { get; set; }

		[Column("FormulaID")]
		public long? FormulaId { get; set; }

		[Column("GST", TypeName = "decimal(18, 2)")]
		public decimal? Gst { get; set; }

		[StringLength(150)]
		[Unicode(false)]
		public string? LastBatchNo { get; set; }

		[Column(TypeName = "datetime")]
		public DateTime? BatchExpDate { get; set; }

		[Column("SupplierID")]
		public long? SupplierId { get; set; }

		public long? DangerLevel { get; set; }

		public long? MaxLevel { get; set; }

		[Column("CategoryID")]
		public long? CategoryId { get; set; }

		[Column("UserID")]
		public long? UserId { get; set; }

		public bool? IsSaleLimit { get; set; }

		public long? AllowSaleQtyPerDay { get; set; }

		[Column("isNarcotics")]
		public bool? IsNarcotics { get; set; }

		[Column(TypeName = "decimal(18, 2)")]
		public decimal? RetailPrice { get; set; }

		[Column(TypeName = "decimal(18, 0)")]
		public decimal? RetailDis { get; set; }

		[StringLength(50)]
		[Unicode(false)]
		public string? Packing { get; set; }

		[Column("isWarranty")]
		public bool? IsWarranty { get; set; }

		public double? Scheme { get; set; }

		public bool? IsExpiry { get; set; }

		[StringLength(100)]
		[Unicode(false)]
		public string? MasterCode { get; set; }

		public int? MasterUom { get; set; }

		[Column(TypeName = "decimal(18, 2)")]
		public decimal? MasterPrice { get; set; }

		[Column(TypeName = "decimal(18, 2)")]
		public decimal? UsedItemsStock { get; set; }

		[Column(TypeName = "decimal(18, 2)")]
		public decimal? WholeSalePrice { get; set; }

		[StringLength(200)]
		[Unicode(false)]
		public string? UrduName { get; set; }

		[Column(TypeName = "decimal(18, 2)")]
		public decimal? FlatSaleCommission { get; set; }

		[Column(TypeName = "decimal(18, 2)")]
		public decimal? PercentageSaleCommission { get; set; }

		[StringLength(50)]
		[Unicode(false)]
		public string? LoosePackingDetails { get; set; }

		public long? BonusOnQty { get; set; }

		public long? BonusGiven { get; set; }

		public bool? NoSalDis { get; set; }

		[Column(TypeName = "decimal(18, 2)")]
		public decimal? Weight { get; set; }

		[Column(TypeName = "decimal(18, 2)")]
		public decimal? PurGstPer { get; set; }

		public long? CortonUom { get; set; }

		[Column(TypeName = "decimal(18, 2)")]
		public decimal? PrintPrice { get; set; }

		[Column("GSTOnPrintPrice", TypeName = "decimal(18, 2)")]
		public decimal? GstonPrintPrice { get; set; }

		[Column(TypeName = "decimal(18, 2)")]
		public decimal? TradePrice { get; set; }

	}


    public class ProductWithCategoryAndCompanyName
    {
        //public Product Product { get; set; }
        public string CategoryName { get; set; }
        public string CompanyName { get; set; }
    }

    public class ProductsWithCategoriesAndUnits
    {
        public List<ProductWithCategoryAndCompanyName> ProductsList { get; set; }
        public List<CategoryVM> LU_Categories { get; set; }
        //public List<LU_Units> LU_Units { get; set; }
    }
}
