using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECS.DataAccess
{
    public class Event : BaseEntity
    {
        public int OwnerId { get; set; }
        [Required]
        public int Module { get; set; }
        [MaxLength(40)]
        public string Title { get; set; }
        [MaxLength(50)]
        public string? Description { get; set; }
        [Required]
        public int Type { get; set; }
        public bool? IsDeleted { get; set; }

    }
}
