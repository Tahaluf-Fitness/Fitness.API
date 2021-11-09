using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using Tahaluf.Fitness.Core.Common;
using Tahaluf.Fitness.Core.Reopsitory;
using Tahaluf.Fitness.Data;

namespace Tahaluf.Fitness.Infra.Repository
{
    public class WebSiteInfoRepository : IWebSiteInfoRepository
    {
        private readonly IDbContext _DbContext;
        public WebSiteInfoRepository(IDbContext _DbContext)
        {
            this._DbContext = _DbContext;
        }
        public bool CreateWebSiteInfo(WebSiteInfo webSiteInfo)
        {
            var p = new DynamicParameters();
            p.Add("@WebSiteName", webSiteInfo.WebSiteName, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@Logo", webSiteInfo.Logo, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@BackgroundImage", webSiteInfo.BackgroundImage, dbType: DbType.String, direction: ParameterDirection.Input);

            p.Add("@PhoneNumber1", webSiteInfo.PhoneNumber1, dbType: DbType.Int32, direction: ParameterDirection.Input);

            p.Add("@PhoneNumber2", webSiteInfo.PhoneNumber2, dbType: DbType.Int32, direction: ParameterDirection.Input);

            p.Add("@Email", webSiteInfo.Email, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@Country", webSiteInfo.Country, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@City", webSiteInfo.City, dbType: DbType.String, direction: ParameterDirection.Input);

            p.Add("@FacebookLink", webSiteInfo.FacebookLink, dbType: DbType.String, direction: ParameterDirection.Input);

            p.Add("@InstgramLink", webSiteInfo.InstgramLink, dbType: DbType.String, direction: ParameterDirection.Input);

            p.Add("@TwiterLink", webSiteInfo.TwiterLink, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@AboutUsId", webSiteInfo.AboutUsId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@ContactId", webSiteInfo.ContactId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@ReviewId", webSiteInfo.ReviewId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = _DbContext.Connection.ExecuteAsync("CreateWebSiteInfo", p, commandType: CommandType.StoredProcedure);

            return true;
        }

        public bool DeleteWebSiteInfo(int id)
        {
            var p = new DynamicParameters();
            p.Add("@WebId", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = _DbContext.Connection.ExecuteAsync("DeleteWebSiteInfo", p, commandType: CommandType.StoredProcedure);

            return true;
        }

        public List<WebSiteInfo> GetWebSiteInfo()
        {
            IEnumerable<WebSiteInfo> result = _DbContext.Connection.Query<WebSiteInfo>("GetWebSiteInfo", CommandType.StoredProcedure);
            return result.ToList();
        }

        public bool UpdateWebSiteInfo(WebSiteInfo webSiteInfo)
        {
            var p = new DynamicParameters();
            p.Add("@WebId", webSiteInfo.WebId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@WebSiteName", webSiteInfo.WebSiteName, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@Logo", webSiteInfo.Logo, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@BackgroundImage", webSiteInfo.BackgroundImage, dbType: DbType.String, direction: ParameterDirection.Input);

            p.Add("@PhoneNumber1", webSiteInfo.PhoneNumber1, dbType: DbType.Int32, direction: ParameterDirection.Input);

            p.Add("@PhoneNumber2", webSiteInfo.PhoneNumber2, dbType: DbType.Int32, direction: ParameterDirection.Input);

            p.Add("@Email", webSiteInfo.Email, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@Country", webSiteInfo.Country, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@City", webSiteInfo.City, dbType: DbType.String, direction: ParameterDirection.Input);

            p.Add("@FacebookLink", webSiteInfo.FacebookLink, dbType: DbType.String, direction: ParameterDirection.Input);

            p.Add("@InstgramLink", webSiteInfo.InstgramLink, dbType: DbType.String, direction: ParameterDirection.Input);

            p.Add("@TwiterLink", webSiteInfo.TwiterLink, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@AboutUsId", webSiteInfo.AboutUsId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@ContactId", webSiteInfo.ContactId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@ReviewId", webSiteInfo.ReviewId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = _DbContext.Connection.ExecuteAsync("UpdateWebSiteInfo", p, commandType: CommandType.StoredProcedure);

            return true;
        }
    }
}
