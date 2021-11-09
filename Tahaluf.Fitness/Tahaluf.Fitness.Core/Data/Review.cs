using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace Tahaluf.Fitness.Data
{
    public partial class Review
    {
        [Key]
        public int ReviewId { get; set; }
        public int? ReviewValue { get; set; }
        public string Name { get; set; }
        public bool? Status { get; set; }
        public string Comment { get; set; }

        public virtual ICollection<WebSiteInfo> WebSiteInfos { get; set; }
    }
}
