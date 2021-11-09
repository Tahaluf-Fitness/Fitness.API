using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace Tahaluf.Fitness.Data
{
    public partial class Disease
    {
        [Key]
        public int DiseaseId { get; set; }
        public string DiseaseTitle { get; set; }
        public int? UserId { get; set; }

        public virtual User User { get; set; }
    }
}
