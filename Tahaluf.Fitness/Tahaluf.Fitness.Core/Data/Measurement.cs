using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace Tahaluf.Fitness.Data
{
    public partial class Measurement
    {
        [Key]
        public int MesurmentId { get; set; }
        public double? Height { get; set; }
        public double? Weight { get; set; }
        public double? Bmi { get; set; }
        public double? BicepsWidth { get; set; }
        public double? ThighWidth { get; set; }
        public double? Chest { get; set; }
        public double? Shoulder { get; set; }
        public double? Waist { get; set; }
        public DateTime? DateOfMeasurement { get; set; }
        public int? UserId { get; set; }

        public virtual User User { get; set; }
    }
}
