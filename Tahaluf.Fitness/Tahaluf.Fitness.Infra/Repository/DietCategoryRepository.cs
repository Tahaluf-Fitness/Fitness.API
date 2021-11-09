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
    public class DietCategoryRepository: IDietCategoryRepository
    {
        private readonly IDbContext dbContext;

        public DietCategoryRepository(IDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public List<DietCategory> GetDietCategory()
        {
            IEnumerable<DietCategory> result = dbContext.Connection.Query<DietCategory>("GetDietCategory", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }
        public bool CreateDietCategory(DietCategory dietCategory)
        {
            var parameter = new DynamicParameters();
            parameter.Add("@CategoryName", dietCategory.CategoryName, dbType: DbType.String, direction: ParameterDirection.Input);
            var result = dbContext.Connection.ExecuteAsync("CreateDietCategory", parameter, commandType: CommandType.StoredProcedure);
            return true;
        }
        public bool UpdateDietCategory(DietCategory dietCategory)
        {
            var parameter = new DynamicParameters();
            parameter.Add("@DietCategoryID",dietCategory.DietCategoryId , dbType: DbType.Int32, direction: ParameterDirection.Input);
            parameter.Add("@CategoryName",dietCategory.CategoryName , dbType: DbType.String, direction: ParameterDirection.Input);
            var result = dbContext.Connection.ExecuteAsync("UpdateDietCategory", parameter, commandType: CommandType.StoredProcedure);
            return true;
        }
        public bool DeleteDietCategory(int id)
        {
            var parameter = new DynamicParameters();
            parameter.Add("@DietCategoryID", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = dbContext.Connection.ExecuteAsync("DeleteDietCategory", parameter, commandType: CommandType.StoredProcedure);
            return true;
        }
    }
}
