using System;
using System.Collections.Generic;
using System.Text;

namespace Tahaluf.Fitness.Core.DTO
{
    public class getDietInfoDTO
    {
        public string DietFile { get; set; }
        public double? DietPeriod { get; set; }
        public int? Actualprice { get; set; }
        public int? CustomerPrice { get; set; }
        public string CategoryName { get; set; }
    }
}
