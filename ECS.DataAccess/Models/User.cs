using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECS.DataAccess
{
    /// <summary>
    /// Entity represents Users table
    /// </summary>
    public class User : BaseEntity
    {
        [MaxLength(30)]
        public string FirstName { get; set; }
        [MaxLength(30)]
        public string LastName { get; set; }
        [MaxLength(60)]
        public string Email { get; set; }
        [MaxLength(12)]
        public string? Password { get; set; }
        public int? Type { get; set; }
        public int? Status { get; set; }
        public bool? IsDeleted { get; set; }
    }
}