using System;
using System.Collections.Generic;
using System.Text;

namespace Tahaluf.Fitness.Core.DTO
{
    public class UserReportDTO
    {

        public int UserID { get; set; }
        public int UserReportID { get; set; }
        public string Email { get; set; }
        public DateTime ReportDate { get; set; }
        public string DietFile { get; set; }
        public string DietImage { get; set; }
        public string DietDescription { get; set; }
        public double? DietPeriod { get; set; }
        public int? Actualprice { get; set; }
        public int? CustomerPrice { get; set; }
        public string CategoryName { get; set; }

    }
}
