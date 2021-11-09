using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace Tahaluf.Fitness.Data
{
    public partial class SportCategory
    {
       
        [Key]
        public int SportCategoryId { get; set; }
        public string CategoryName { get; set; }

        public virtual ICollection<Sport> Sports { get; set; }
    }
}
