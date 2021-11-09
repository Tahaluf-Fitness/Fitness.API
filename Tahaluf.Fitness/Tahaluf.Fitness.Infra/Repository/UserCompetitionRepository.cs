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
   public class UserCompetitionRepository : IUserCompetitionRepository
    {
        private readonly IDbContext _DbContext;
        public UserCompetitionRepository(IDbContext _DbContext)
        {
            this._DbContext = _DbContext;
        }

        public bool CreateUserCompetition(UserCompetition userCompetition)
        {
            var p = new DynamicParameters();
            p.Add("@UserId", userCompetition.UserId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@CompetitionId", userCompetition.CompetitionId, dbType: DbType.Int32, direction: ParameterDirection.Input);
        
            var result = _DbContext.Connection.ExecuteAsync("CreateUserCompetition", p, commandType: CommandType.StoredProcedure);

            return true;
        }

        public bool DeleteUserCompetition(int id)
        {
            var p = new DynamicParameters();
            p.Add("@UserCompetitionID", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = _DbContext.Connection.ExecuteAsync("DeleteUserCompetition", p, commandType: CommandType.StoredProcedure);

            return true;
        }

        public List<UserCompetition> GetUserCompetition()
        {
            IEnumerable<UserCompetition> result = _DbContext.Connection.Query<UserCompetition>("GetUserCompetition", CommandType.StoredProcedure);
            return result.ToList();
        }

        public bool UpdateUserCompetition(UserCompetition userCompetition)
        {
            var p = new DynamicParameters();
            p.Add("@UserCompetitionId", userCompetition.UserCompetitionId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@UserId", userCompetition.UserId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@CompetitionId", userCompetition.CompetitionId, dbType: DbType.Int32, direction: ParameterDirection.Input);

            var result = _DbContext.Connection.ExecuteAsync("UpdateUserCompetition", p, commandType: CommandType.StoredProcedure);

            return true;
        }
    }
}
