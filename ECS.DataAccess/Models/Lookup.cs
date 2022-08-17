using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECS.DataAccess
{
    public class Lookup : BaseEntity
    {
        public int LookupTypeId { get; set; }

        [Required]
        [MaxLength(50)]
        public string LookupDescription { get; set; }
        public bool IsActive { get; set; }
        public bool CanDelete { get; set; }
    }
}
