using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using Tahaluf.Fitness.Core.Common;

namespace Tahaluf.Fitness.Core.Reopsitory
{
    public class AboutUsRepository: IAboutUsRepository
    {

        private readonly IDbContext dbContext;

        public AboutUsRepository(IDbContext _dbContext)
        {
            dbContext = _dbContext;
        }

        public bool CreateAboutUs(AboutUs aboutUs)
        {
            var p = new DynamicParameters();
            p.Add("@Title", aboutUs.Title, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@SubTitle", aboutUs.SubTitle, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@Description", aboutUs.Description, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@Image", aboutUs.Image, dbType: DbType.String, direction: ParameterDirection.Input);
            var result = dbContext.Connection.ExecuteAsync("CreateAboutUs", p, commandType: CommandType.StoredProcedure);
            return true;

        }

        public bool UpdateAboutUs(AboutUs aboutUs)
        {
            var p = new DynamicParameters();
            p.Add("@Title", aboutUs.Title, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@SubTitle", aboutUs.SubTitle, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@Description", aboutUs.Description, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@Image", aboutUs.Image, dbType: DbType.String, direction: ParameterDirection.Input);
            var result = dbContext.Connection.ExecuteAsync("UpdateAboutUs", p, commandType: CommandType.StoredProcedure);
            return true;
        }

        public bool DeleteAboutUs(int id)
        {
            var p = new DynamicParameters();
            p.Add("@AboutUsID", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = dbContext.Connection.ExecuteAsync("DeleteAboutUs", p, commandType: CommandType.StoredProcedure);
            return true;
        }

        public List<AboutUs> GetAboutUs()
        {
            IEnumerable<AboutUs> result = dbContext.Connection.Query<AboutUs>("GetAboutUs", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }
    }
}
