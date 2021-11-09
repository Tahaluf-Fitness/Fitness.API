using System;
using System.Collections.Generic;

#nullable disable

namespace Tahaluf.Fitness.Core
{
    public partial class CompetioinCategory
    {
       

        public int CompetioinCategoryId { get; set; }
        public string CompetioinCategoryName { get; set; }

        public virtual ICollection<Competition> Competitions { get; set; }
    }
}
