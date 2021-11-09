using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Tahaluf.Fitness.Data;

#nullable disable

namespace Tahaluf.Fitness.Core
{
    public partial class AboutUs
    {
        [Key]
        public int AboutUsId { get; set; }
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }

        public virtual ICollection<WebSiteInfo> WebSiteInfos { get; set; }
    }
}
