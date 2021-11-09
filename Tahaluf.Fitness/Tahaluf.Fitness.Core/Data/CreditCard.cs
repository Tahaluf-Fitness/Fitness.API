using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace Tahaluf.Fitness.Data
{
    public partial class CreditCard
    {
        [Key]
        public int CreditCardId { get; set; }
        public int Code { get; set; }
        public string Password { get; set; }
        public DateTime ExpireDate { get; set; }
        public int TotalMoney { get; set; }
        public int? UserId { get; set; }

        public virtual User User { get; set; }
    }
}
