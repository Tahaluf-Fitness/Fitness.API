using System;
using System.Collections.Generic;
using System.Text;
using Tahaluf.Fitness.Core.Reopsitory;
using Tahaluf.Fitness.Core.Service;
using Tahaluf.Fitness.Data;

namespace Tahaluf.Fitness.Infra.Service
{
    public class WebSiteInfoService : IWebSiteInfoService
    {
        private readonly IWebSiteInfoRepository webSiteInfoRepository;
        public WebSiteInfoService(IWebSiteInfoRepository _webSiteInfoRepository)
        {
            webSiteInfoRepository = _webSiteInfoRepository;
        }
        public bool CreateWebSiteInfo(WebSiteInfo webSiteInfo)
        {
            return webSiteInfoRepository.CreateWebSiteInfo(webSiteInfo);
        }

        public bool DeleteWebSiteInfo(int id)
        {
            return webSiteInfoRepository.DeleteWebSiteInfo(id);
        }

        public List<WebSiteInfo> GetWebSiteInfo()
        {
            return webSiteInfoRepository.GetWebSiteInfo();
        }

        public bool UpdateWebSiteInfo(WebSiteInfo webSiteInfo)
        {
            return webSiteInfoRepository.UpdateWebSiteInfo(webSiteInfo);
        }
    }
}
