using System;
using System.Collections.Generic;
using System.Text;
using Tahaluf.Fitness.Core.Reopsitory;
using Tahaluf.Fitness.Core.Service;
using Tahaluf.Fitness.Data;

namespace Tahaluf.Fitness.Infra.Service
{
    public class ContactUsService:IContactUsService
    {
        private readonly IContactUsRepository contactUsRepository;

        public ContactUsService(IContactUsRepository contactUsRepository)
        {
            this.contactUsRepository = contactUsRepository;
        }

        public List<ContactUs> GetContactUs()
        {
            return contactUsRepository.GetContactUs();
        }
        public bool CreateContactUs(ContactUs contact)
        {
            return contactUsRepository.CreateContactUs(contact);
        }
        public bool UpdateContactUs(ContactUs contact)
        {
           return contactUsRepository.UpdateContactUs(contact);
        }
        public bool DeleteContactUs(int id)
        {
            return contactUsRepository.DeleteContactUs(id);
        }
       

    }
}
