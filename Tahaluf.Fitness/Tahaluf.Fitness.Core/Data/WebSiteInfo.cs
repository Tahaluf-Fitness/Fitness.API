using System;
using System.Collections.Generic;
using Tahaluf.Fitness.Core;

#nullable disable

namespace Tahaluf.Fitness.Data
{
    public partial class WebSiteInfo
    {
        public int WebId { get; set; }
        public string WebSiteName { get; set; }
        public string Logo { get; set; }
        public string BackgroundImage { get; set; }
        public int? PhoneNumber1 { get; set; }
        public int? PhoneNumber2 { get; set; }
        public string Email { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string FacebookLink { get; set; }
        public string InstgramLink { get; set; }
        public string TwiterLink { get; set; }
        public int? AboutUsId { get; set; }
        public int? ContactId { get; set; }
        public int? TeamId { get; set; }
        public int? ReviewId { get; set; }

        public virtual AboutUs AboutUs { get; set; }
        public virtual ContactUs Contact { get; set; }
        public virtual Review Review { get; set; }
    }
}
