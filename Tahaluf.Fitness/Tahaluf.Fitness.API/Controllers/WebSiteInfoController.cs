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
    public class WebSiteInfoController : Controller
    {
        private readonly IWebSiteInfoService webSiteInfoService;
        public WebSiteInfoController(IWebSiteInfoService _webSiteInfoService)
        {
            webSiteInfoService = _webSiteInfoService;
        }

        [HttpGet]
        [ProducesResponseType(typeof(List<WebSiteInfo>), StatusCodes.Status200OK)]
        public List<WebSiteInfo> GetWebSiteInfo()
        {
            return webSiteInfoService.GetWebSiteInfo();
        }


        [HttpPost]
        [ProducesResponseType(typeof(WebSiteInfo), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool CreateWebSiteInfo(WebSiteInfo webSiteInfo)
        {
            return webSiteInfoService.CreateWebSiteInfo(webSiteInfo);
        }


        [HttpPut]
        [ProducesResponseType(typeof(WebSiteInfo), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public bool UpdateWebSiteInfo(WebSiteInfo webSiteInfo)
        {
            return webSiteInfoService.UpdateWebSiteInfo(webSiteInfo);
        }


        [HttpDelete]
        [Route("delete/{id}")]
        [ProducesResponseType(typeof(WebSiteInfo), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool DeleteWebSiteInfo(int id)
        {
            return webSiteInfoService.DeleteWebSiteInfo(id);
        }



    }
}
