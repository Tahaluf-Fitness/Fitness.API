using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace Tahaluf.Fitness.Data
{
    public partial class Notification
    {
        [Key]
        public int NotificationId { get; set; }
        public string Msg { get; set; }
        public int? UserId { get; set; }

        public virtual User User { get; set; }
    }
}
