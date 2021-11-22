using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using Tahaluf.Fitness.Core.Common;
using Tahaluf.Fitness.Core.Data;
using Tahaluf.Fitness.Core.Reopsitory;

namespace Tahaluf.Fitness.Infra.Repository
{
    public class BestFoodRepository : IBestFoodRepository
    {
        private readonly IDbContext dbContext;

        public BestFoodRepository(IDbContext dbContext)
        {
            this.dbContext = dbContext;
        }


        public List<BestFood> GetBestFood()
        {
            IEnumerable<BestFood> result = dbContext.Connection.Query<BestFood>("GetBestFood", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public bool CreateBestFood(BestFood bestFood)
        {
            var parameter = new DynamicParameters();
            parameter.Add("@Title", bestFood.Title, dbType: DbType.String, direction: ParameterDirection.Input);
            parameter.Add("@Descriptions",bestFood.Descriptions , dbType: DbType.String, direction: ParameterDirection.Input);
            parameter.Add("@ImageFood", bestFood.ImageFood, dbType: DbType.String, direction: ParameterDirection.Input);
            parameter.Add("@Subtitle",bestFood.Subtitle , dbType: DbType.String, direction: ParameterDirection.Input);
            var result = dbContext.Connection.ExecuteAsync("CreateBestFood", parameter, commandType: CommandType.StoredProcedure);
            return true;

        }
        public bool UpdateBestFood(BestFood bestFood)
        {
            var parameter = new DynamicParameters();
            parameter.Add("@BestFoodId", bestFood.BestfoodId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            parameter.Add("@Title", bestFood.Title, dbType: DbType.String, direction: ParameterDirection.Input);
            parameter.Add("@Descriptions", bestFood.Descriptions, dbType: DbType.String, direction: ParameterDirection.Input);
            parameter.Add("@ImageFood", bestFood.ImageFood, dbType: DbType.String, direction: ParameterDirection.Input);
            parameter.Add("@Subtitle", bestFood.Subtitle, dbType: DbType.String, direction: ParameterDirection.Input);
            var result = dbContext.Connection.ExecuteAsync("UpdateBestFood", parameter, commandType: CommandType.StoredProcedure);
            return true;
        }
        public bool DeleteBestFood(int id)
        {
            var parameter = new DynamicParameters();
            parameter.Add("@BestFoodId", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = dbContext.Connection.ExecuteAsync("DeleteBestFood", parameter, commandType: CommandType.StoredProcedure);
            return true;
        }
    }
}
