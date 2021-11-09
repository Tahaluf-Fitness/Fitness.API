using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tahaluf.Fitness.Core;
using Tahaluf.Fitness.Core.Service;

namespace Tahaluf.Fitness.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AboutUsController : Controller
    {
        private readonly IAboutUsService aboutUsService;

        public AboutUsController(IAboutUsService _aboutUsService)
        {
            aboutUsService = _aboutUsService;
        }

        [HttpPost]
        [ProducesResponseType(typeof(AboutUs), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool CreateAboutUs([FromBody] AboutUs aboutUs)
        {
            return aboutUsService.CreateAboutUs(aboutUs);
        }

        [HttpGet]
        [ProducesResponseType(typeof(List<AboutUs>), StatusCodes.Status200OK)]
        public List<AboutUs> GetAboutUs()
        {
            return aboutUsService.GetAboutUs();
        }

        [HttpPut]
        [ProducesResponseType(typeof(AboutUs), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool UpdateAboutUs(AboutUs aboutus)
        {
            return aboutUsService.UpdateAboutUs(aboutus);
        }

        [HttpDelete]
        [Route("delete/{id}")]
        [ProducesResponseType(typeof(AboutUs), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool DeleteAboutUs(int id)
        {
            return aboutUsService.DeleteAboutUs(id);
        }
    }
}
