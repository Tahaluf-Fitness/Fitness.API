using System;
using System.Collections.Generic;
using Tahaluf.Fitness.Data;

#nullable disable

namespace Tahaluf.Fitness.Core
{
    public partial class Competition
    {
       

        public int CompetitionId { get; set; }
        public string CompetitionName { get; set; }
        public string CompetitionImage { get; set; }
        public string Description { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public int? TotalMembers { get; set; }
        public string WinnerName { get; set; }
        public int? CompetitionCategoryID { get; set; }

        public virtual CompetioinCategory CompetioinCategory { get; set; }
        public virtual ICollection<CompetitionComment> CompetitionComments { get; set; }
        public virtual ICollection<UserCompetition> UserCompetitions { get; set; }
    }
}
