using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Tahaluf.Fitness.Data;

#nullable disable

namespace Tahaluf.Fitness.Core
{
    public partial class Attendance
    {
        [Key]
        public int AttendanceId { get; set; }
        public DateTime? DateOfDay { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public int? UserId { get; set; }

        public virtual User User { get; set; }
    }
}
