using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tahaluf.Fitness.Core.Service;
using Tahaluf.Fitness.Data;

namespace Tahaluf.Fitness.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactUsController : Controller
    {
        private readonly IContactUsService contactUsService;


        public ContactUsController(IContactUsService contactUsService)
        {
            this.contactUsService = contactUsService;
        }

        [HttpGet]
        [ProducesResponseType(typeof(List<ContactUs>), StatusCodes.Status200OK)]
        public List<ContactUs> GetContactUs()
        {
            return contactUsService.GetContactUs();
        }

        [HttpPost]
        [ProducesResponseType(typeof(List<ContactUs>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool CreateContactUs(ContactUs contact)
        {
            return contactUsService.CreateContactUs(contact);
        }

        [HttpPut]
        [ProducesResponseType(typeof(List<ContactUs>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public void UpdateContactUs(ContactUs contact)
        {
            contactUsService.UpdateContactUs(contact);
        }


        [HttpDelete]
        [Route("delete/{id}")]
        [ProducesResponseType(typeof(List<ContactUs>), StatusCodes.Status200OK)]
        public bool DeleteContactUs(int id)
        {
            return contactUsService.DeleteContactUs(id);
        }

      
    }
}
