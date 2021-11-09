using System;
using System.Collections.Generic;
using System.Text;
using Tahaluf.Fitness.Data;

namespace Tahaluf.Fitness.Core.Service
{
    public interface IContactUsService
    {
        public List<ContactUs> GetContactUs();
        public bool CreateContactUs(ContactUs contact);
        public bool UpdateContactUs(ContactUs contact);
        public bool DeleteContactUs(int id);
    }
}
