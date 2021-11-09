using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using Tahaluf.Fitness.Core;
using Tahaluf.Fitness.Core.Common;
using Tahaluf.Fitness.Core.Reopsitory;

namespace Tahaluf.Fitness.Infra.Repository
{
    public class AttendanceRepository: IAttendanceRepository
    {
        private readonly IDbContext dbContext;

        public AttendanceRepository(IDbContext _dbContext)
        {
            dbContext = _dbContext;
        }

        public bool CreateAttendance(Attendance attendance)
        {
            var p = new DynamicParameters();
            p.Add("@DateOfDay", attendance.DateOfDay, dbType: DbType.Date, direction: ParameterDirection.Input);
            p.Add("@StartTime", attendance.StartTime, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@EndTime", attendance.EndTime, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@UserID", attendance.UserId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = dbContext.Connection.ExecuteAsync("CreateAttendance", p, commandType: CommandType.StoredProcedure);
            return true;
        }
        public bool UpdateAttendance(Attendance attendance)
        {
            var p = new DynamicParameters();
            p.Add("@DateOfDay", attendance.DateOfDay, dbType: DbType.Date, direction: ParameterDirection.Input);
            p.Add("@StartTime", attendance.StartTime, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@EndTime", attendance.EndTime, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@UserID", attendance.UserId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = dbContext.Connection.ExecuteAsync("UpdateAttendance", p, commandType: CommandType.StoredProcedure);
            return true;
        }

        public bool DeleteAttendance(int id)
        {
            var p = new DynamicParameters();
            p.Add("@AttendanceID", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = dbContext.Connection.ExecuteAsync("DeleteAttendance", p, commandType: CommandType.StoredProcedure);
            return true;
        }

        public List<Attendance> GetAttendance()
        {
            IEnumerable<Attendance> result = dbContext.Connection.Query<Attendance>("GetAttendance", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }
    }
}
