using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Tahaluf.Fitness.Data;

namespace Tahaluf.Fitness.Core.Data
{
    public class UserReports
    {

        [Key]
        public int UserReportID { get; set; }
        public  DateTime ReportDate { get; set; }
        public int? UserID { get; set; }
        public int? DietReportID { get; set; }

        public virtual DietReport DietReport { get; set; }
        public virtual User User { get; set; }
    }
}
