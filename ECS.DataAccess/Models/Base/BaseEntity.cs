using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECS.DataAccess
{
    public class BaseEntity
    {
        public int Id { get; set; }

        [Required]
        public DateTime CreatedOn { get; set; }

        [Required]
        public int CreatedBy { get; set; }

        public DateTime UpdatedOn { get; set; }
        public int UpdatedBy { get; set; }

    }
}
