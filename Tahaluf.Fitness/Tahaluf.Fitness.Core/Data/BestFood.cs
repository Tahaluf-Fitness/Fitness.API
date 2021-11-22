using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Tahaluf.Fitness.Data;

namespace Tahaluf.Fitness.Core.Data
{
    public partial class BestFood
    {
        [Key]
        public int BestfoodId { get; set; }
        public string Title { get; set; }
        public string Descriptions { get; set; }
        public string ImageFood { get; set; }
        public string Subtitle { get; set; }
    }
}
