using System;
using System.Collections.Generic;
using System.Text;

namespace Tahaluf.Fitness.Core.DTO
{
    public class CompetitionCategoryDTO
    {
        public string CompetitionName { get; set; }
        public string CompetioinImage { get; set; }

        public string Description { get; set; }

        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }

        public int  TotalMembers { get; set; }

        public string WinnerName { get; set; }

        public string CompetioinCategoryName { get; set; }


    }
}
