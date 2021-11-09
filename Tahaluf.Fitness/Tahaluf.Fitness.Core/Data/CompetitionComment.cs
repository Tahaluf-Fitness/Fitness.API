using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Tahaluf.Fitness.Core;

#nullable disable

namespace Tahaluf.Fitness.Data
{
    
    public partial class CompetitionComment
    {
        [Key]
        public int CompetitionCommentId { get; set; }
        public string Comment { get; set; }
        public int? UserId { get; set; }
        public int? CompetitionId { get; set; }

        public virtual Competition Competition { get; set; }
        public virtual User User { get; set; }
    }
}
