using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace Tahaluf.Fitness.Data
{
    public partial class DietCategory
    {
        
        [Key]
        public int DietCategoryId { get; set; }
        public string CategoryName { get; set; }

        public virtual ICollection<DietReport> DietReports { get; set; }
    }
}
