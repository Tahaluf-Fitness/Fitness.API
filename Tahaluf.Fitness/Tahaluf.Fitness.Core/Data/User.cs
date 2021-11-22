using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Tahaluf.Fitness.Core;
using Tahaluf.Fitness.Core.Data;

#nullable disable

namespace Tahaluf.Fitness.Data
{
    public partial class User
    {
     
        [Key]
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public string Gender { get; set; }
        public string UserImage { get; set; }
        public int? PhoneNumber1 { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Position { get; set; }
        public int? Salary { get; set; }
        public DateTime? JoinDate { get; set; }
        public int? RoleId { get; set; }

        public virtual Role Role { get; set; }
        public virtual ICollection<Attendance> Attendances { get; set; }
        public virtual ICollection<CompetitionComment> CompetitionComments { get; set; }
        public virtual ICollection<CreditCard> CreditCards { get; set; }
        public virtual ICollection<Disease> Diseases { get; set; }
        public virtual ICollection<Measurement> Measurements { get; set; }
        public virtual ICollection<Notification> Notifications { get; set; }
        public virtual ICollection<UserReports> UserReports { get; set; }
        public virtual ICollection<UserCompetition> UserCompetitions { get; set; }
        public virtual ICollection<UserMessage> UserMessages { get; set; }
    }
}
