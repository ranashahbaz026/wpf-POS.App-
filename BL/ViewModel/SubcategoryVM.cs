  
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
    public class SubcategoryVM
    {
        public int ID { get; set; }
        [Required]
        public int Category_ID { get; set; }              
        public string? Category_Name { get; set; }        
        [Required]
        public string Subcategory_Name { get; set; }
    }
    
    public class UpdateSubcategoryVM
    {
        [Required]
        public int ID { get; set; }    
        [Required]
        public string Sub_Category_Name { get; set; }
    }
    
    public class CreateSubcategoryVM
    {
        [Required]
        public int Category_ID { get; set; }    
        [Required]
        public string Sub_Category_Name { get; set; }
    }
    
}
