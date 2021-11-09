using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace Tahaluf.Fitness.Data
{
    public partial class Role
    {
        [Key]
        public int RoleId { get; set; }
        public  string RoleName { get; set; }

        public virtual ICollection<User> Users { get; set; }
    }
}
