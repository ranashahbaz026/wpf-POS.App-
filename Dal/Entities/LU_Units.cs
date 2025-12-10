using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class LU_Units : SoftDeletedEntity
    {
        public string Unit { get; set; }
    }
}
