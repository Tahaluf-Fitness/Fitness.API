using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace Tahaluf.Fitness.Data
{
    public partial class Sport
    {
        [Key]
        public int SportId { get; set; }
        public string SportName { get; set; }
        public int? Repetition { get; set; }
        public string VideoName { get; set; }
        public string VideoLink { get; set; }
        public int? SportCategoryId { get; set; }

        public virtual SportCategory SportCategory { get; set; }
    }
}
