  
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
    public class CategoryVM
    {
        public int ID { get; set; }

        [StringLength(200)] 
        public string? Name { get; set; }

        [StringLength(500)] 
        public string? Remarks { get; set; }
    }
    
    public class DeleteCategoryVM
    {
        public int categoryId { get; set; }
    }
}
