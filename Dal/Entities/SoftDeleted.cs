
using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class SoftDeletedEntity : BaseEntity
    {
        public bool Deleted { get; set; } = false;
        public DateTime? DeletedAt { get; set; }
        public Guid DeletedBy { get; set; }
    }
}
