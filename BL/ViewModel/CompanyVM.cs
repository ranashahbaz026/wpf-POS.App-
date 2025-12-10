
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
    public class CompanyVM
    {
        public long Id { get; set; }

        public string? CompanyName { get; set; }

        public string? PhoneNo { get; set; }

        public string? Address { get; set; }

        public string? Remarks { get; set; }

        //public bool? IsActive { get; set; } = true;

        //public bool? ApplyTax { get; set; }
    }

}
