using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using Tahaluf.Fitness.Core.Common;
using Tahaluf.Fitness.Core.Data;
using Tahaluf.Fitness.Core.DTO;
using Tahaluf.Fitness.Core.Reopsitory;

namespace Tahaluf.Fitness.Infra.Repository
{
    public class UserReportsRepository: IUserReportsRepository
    {
        private readonly IDbContext dbContext;

        public UserReportsRepository(IDbContext _dbContext)
        {
            dbContext = _dbContext;
        }

        public List<UserReportDTO> GetUserReportByID(int id)
        {
            var p = new DynamicParameters();
            p.Add("@UserID", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            IEnumerable<UserReportDTO> result = dbContext.Connection.Query<UserReportDTO>("GetUserReportByID", p , commandType: CommandType.StoredProcedure);
            return result.ToList();
        }
        public List<UserReportDTO> GetAllUserReport()
        {
            IEnumerable<UserReportDTO> result = dbContext.Connection.Query<UserReportDTO>("GetAllUserReport", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }
      

        public bool DeleteUserReport(int id)
        {
            var p = new DynamicParameters();
            p.Add("@DietReportID", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = dbContext.Connection.ExecuteAsync("deleteUserReport", p, commandType: CommandType.StoredProcedure);
            return true;
        }

        public bool CreateUserReport(UserReports userReports)
        {
            var p = new DynamicParameters();
            p.Add("@ReportDate", userReports.ReportDate, dbType: DbType.Date, direction: ParameterDirection.Input);
            p.Add("@UserID", userReports.UserID, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@DietReportID", userReports.DietReportID, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = dbContext.Connection.ExecuteAsync("createUserReport", p, commandType: CommandType.StoredProcedure);
            return true;
        }

        public List<SearchDietByUserEmailDTO> SearchDietByUserEmailDTO(string email)
        {
            var p = new DynamicParameters();
            p.Add("@Email", email, dbType: DbType.String, direction: ParameterDirection.Input);
            IEnumerable<SearchDietByUserEmailDTO> result = dbContext.Connection.Query<SearchDietByUserEmailDTO>("searchUserDietByEmail", p, commandType: CommandType.StoredProcedure);
            return result.ToList();
        }
    }
}
