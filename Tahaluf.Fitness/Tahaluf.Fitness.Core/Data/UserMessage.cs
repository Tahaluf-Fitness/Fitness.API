using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace Tahaluf.Fitness.Data
{
    public partial class UserMessage
    {
        [Key]
        public int UserMessageId { get; set; }
        public int? UserId { get; set; }
        public int? MsgId { get; set; }

        public virtual Message Msg { get; set; }
        public virtual User User { get; set; }
    }
}
