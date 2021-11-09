using System;
using System.Collections.Generic;
using System.Text;

namespace Tahaluf.Fitness.Core.DTO
{
    public  class ClientDTO
    {
        public string Username { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
       
        public string Gender { get; set; }
        public string UserImage { get; set; }
        public int? PhoneNumber1 { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public DateTime? JoinDate { get; set; }

        public string Position { get; set; }
        public int? Salary { get; set; }


    }
}
