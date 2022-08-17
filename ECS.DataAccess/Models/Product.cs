using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECS.DataAccess
{
    public class Product : BaseEntity
    {
        public int CategoryId { get; set; }

        [Required]
        [MaxLength(30)]
        public string Name { get; set; }
        [MaxLength(120)]
        public string Description { get; set; }
        [Required]
        public int Quantity { get; set; }
        public int Price { get; set; }
        public int Status { get; set; }
        public bool IsDeleted { get; set; }
    }
}