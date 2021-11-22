using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using Tahaluf.Fitness.Core.Common;
using Tahaluf.Fitness.Core.DTO;
using Tahaluf.Fitness.Core.Reopsitory;
using Tahaluf.Fitness.Data;

namespace Tahaluf.Fitness.Infra.Repository
{
    public class DietReportRepository: IDietReportRepository
    {
        private readonly IDbContext dbContext;

        public DietReportRepository(IDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public List<DietReportDTO> GetDietReport()
        {
            IEnumerable<DietReportDTO> result = dbContext.Connection.Query<DietReportDTO>("GetAllDietReport", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

       
        public bool CreateDietReport(DietReport dietReport)
        {
            var parameter = new DynamicParameters();
            parameter.Add("@DietFile",dietReport.DietFile, dbType: DbType.String, direction: ParameterDirection.Input);
            parameter.Add("@DietImage", dietReport.DietImage, dbType: DbType.String, direction: ParameterDirection.Input);
            parameter.Add("@DietDescription", dietReport.DietDescription, dbType: DbType.String, direction: ParameterDirection.Input);
            parameter.Add("@DietPeriod", dietReport.DietPeriod, dbType: DbType.Double, direction: ParameterDirection.Input);
            parameter.Add("@Actualprice", dietReport.Actualprice, dbType: DbType.Int32, direction: ParameterDirection.Input);
            parameter.Add("@CustomerPrice", dietReport.CustomerPrice, dbType: DbType.Int32, direction: ParameterDirection.Input);
            parameter.Add("@DietCategoryID", dietReport.DietCategoryId, dbType: DbType.Int32, direction: ParameterDirection.Input);

            var result = dbContext.Connection.ExecuteAsync("CreateDietReport", parameter, commandType: CommandType.StoredProcedure);
            return true;
        }
        public bool UpdateDietReport(DietReport dietReport)
        {
            var parameter = new DynamicParameters();
            parameter.Add("@DietReportID",dietReport.DietReportId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            parameter.Add("@DietFile", dietReport.DietFile, dbType: DbType.String, direction: ParameterDirection.Input);
            parameter.Add("@DietImage", dietReport.DietImage, dbType: DbType.String, direction: ParameterDirection.Input);
            parameter.Add("@DietDescription", dietReport.DietDescription, dbType: DbType.String, direction: ParameterDirection.Input);
            parameter.Add("@DietPeriod", dietReport.DietPeriod, dbType: DbType.Double, direction: ParameterDirection.Input);
            parameter.Add("@Actualprice", dietReport.Actualprice, dbType: DbType.Int32, direction: ParameterDirection.Input);
            parameter.Add("@CustomerPrice", dietReport.CustomerPrice, dbType: DbType.Int32, direction: ParameterDirection.Input);
            parameter.Add("@DietCategoryID", dietReport.DietCategoryId, dbType: DbType.Int32, direction: ParameterDirection.Input);

            var result = dbContext.Connection.ExecuteAsync("UpdateDietReport", parameter, commandType: CommandType.StoredProcedure);
            return true;
        }
        public bool DeleteDietReport(int id)
        {
            var parameter = new DynamicParameters();
            parameter.Add("@DietReportID", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = dbContext.Connection.ExecuteAsync("DeleteDietReport", parameter, commandType: CommandType.StoredProcedure);
            return true;
        }
    }
}
