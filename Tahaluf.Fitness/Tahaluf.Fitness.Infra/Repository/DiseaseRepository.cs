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
    public class DiseaseRepository:IDiseaseRepository
    {
        private readonly IDbContext dbContext;

        public DiseaseRepository(IDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public List<Disease> GetDisease()
        {
            IEnumerable<Disease> result = dbContext.Connection.Query<Disease>("GetDisease", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public List<Disease> GetDiseaseByUserID(int id)
        {
            var parameter = new DynamicParameters();
            parameter.Add("@UserID", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            IEnumerable<Disease> result = dbContext.Connection.Query<Disease>("getDiseaseByUserID",parameter, commandType: CommandType.StoredProcedure);
            return result.ToList();
        }
        public bool CreateDisease(Disease disease)
        {
            var parameter = new DynamicParameters();
            parameter.Add("@DiseaseTitle",disease.DiseaseTitle , dbType: DbType.String, direction: ParameterDirection.Input);
            parameter.Add("@UserID",disease.UserId , dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = dbContext.Connection.ExecuteAsync("CreateDisease", parameter, commandType: CommandType.StoredProcedure);
            return true;
        }
        public bool UpdateDisease(Disease disease,int id)
        {
            var parameter = new DynamicParameters();
            parameter.Add("@DiseaseID", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            parameter.Add("@DiseaseTitle", disease.DiseaseTitle, dbType: DbType.String, direction: ParameterDirection.Input);
            parameter.Add("@UserID", disease.UserId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = dbContext.Connection.ExecuteAsync("UpdateDisease", parameter, commandType: CommandType.StoredProcedure);
            return true;
        }
        public bool DeleteDisease(int id)
        {
            var parameter = new DynamicParameters();
            parameter.Add("@DiseaseID", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = dbContext.Connection.ExecuteAsync("DeleteDisease", parameter, commandType: CommandType.StoredProcedure);
            return true;
        }
    }
}
