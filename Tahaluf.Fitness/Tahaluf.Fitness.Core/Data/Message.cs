using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace Tahaluf.Fitness.Data
{
    public partial class Message
    {
       
        [Key]
        public int MsgId { get; set; }
        public string SenderName { get; set; }
        public string MsgTitle { get; set; }
        public string Description { get; set; }

        public virtual ICollection<UserMessage> UserMessages { get; set; }
    }
}
