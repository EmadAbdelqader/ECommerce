using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECS.DataAccess
{
    public class LookupType : BaseEntity
    {
        [MaxLength(50)]
        public string TypeName { get; set; }
        public bool? IsActive { get; set; }
        public List<Lookup> Lookups { get; set; } = new List<Lookup>();

    }
}