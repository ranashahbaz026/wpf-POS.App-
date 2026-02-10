using Entities;

namespace Domain.Entities
{
    public class Categories : SoftDeletedEntity
    {
        public string Category_Name { get; set; }
    }
}
