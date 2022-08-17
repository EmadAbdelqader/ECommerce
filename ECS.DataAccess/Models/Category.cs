using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECS.DataAccess
{
    public class Category : BaseEntity
    {
        [MaxLength(20)] // nvarchar(max) => nvarchar(30)  nvarchar (4 bytes)
        public string Name { get; set; }

        [MaxLength(50)]
        public string Description { get; set; }

        [Required]
        public bool IsActive { get; set; }

        public bool IsDeleted { get; set; }

        public List<Product> Products { get; set; } = new List<Product>();
    }
}