using System;
using System.Collections.Generic;
using System.Text;
using Tahaluf.Fitness.Data;

namespace Tahaluf.Fitness.Core.Service
{
   public interface IWebSiteInfoService
    {
        bool CreateWebSiteInfo(WebSiteInfo webSiteInfo);
        bool UpdateWebSiteInfo(WebSiteInfo webSiteInfo);
        bool DeleteWebSiteInfo(int id);
        List<WebSiteInfo> GetWebSiteInfo();
    }
}
