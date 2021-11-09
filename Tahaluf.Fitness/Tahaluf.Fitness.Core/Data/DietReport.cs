using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace Tahaluf.Fitness.Data
{
    public partial class DietReport
    {
        [Key]
        public int DietReportId { get; set; }
        public string DietFile { get; set; }
        public string DietImage { get; set; }
        public string DietDescription { get; set; }
        public double? DietPeriod { get; set; }
        public int? Actualprice { get; set; }
        public int? CustomerPrice { get; set; }
        public DateTime? ReportDate { get; set; }
        public int? UserId { get; set; }
        public int? DietCategoryId { get; set; }

        public virtual DietCategory DietCategory { get; set; }
        public virtual User User { get; set; }
    }
}
