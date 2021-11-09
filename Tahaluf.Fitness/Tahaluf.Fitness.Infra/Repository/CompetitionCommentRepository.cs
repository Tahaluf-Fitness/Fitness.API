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
   public class CompetitionCommentRepository: ICompetitionCommentRepository
    {
        private readonly IDbContext dbContext;

        public CompetitionCommentRepository(IDbContext _dbContext)
        {
            dbContext = _dbContext;
        }

        public bool UpdateCompetitionComment(CompetitionComment competitionComment)
        {
            var p = new DynamicParameters();
            p.Add("@Comment", competitionComment.Comment, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@UserID", competitionComment.UserId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@CompetitionID", competitionComment.CompetitionId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            

            var result = dbContext.Connection.ExecuteAsync("UpdateCompetitionComment", p, commandType: CommandType.StoredProcedure);
            return true;
        }
        public bool CreateCompetitionComment(CompetitionComment competitionComment)
        {
            var p = new DynamicParameters();
            p.Add("@Comment", competitionComment.Comment, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@UserID", competitionComment.UserId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@CompetitionID", competitionComment.CompetitionId, dbType: DbType.Int32, direction: ParameterDirection.Input);


            var result = dbContext.Connection.ExecuteAsync("CreateCompetitionComment", p, commandType: CommandType.StoredProcedure);
            return true;
        }

        public bool DeleteCompetitionComment(int id)
        {
            var p = new DynamicParameters();
            p.Add("@CompetitionCommentID", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = dbContext.Connection.ExecuteAsync("DeleteCompetitionComment", p, commandType: CommandType.StoredProcedure);
            return true;
        }
        public List<CompetitionComment> GetCompetitionComment()
        {
            IEnumerable<CompetitionComment> result = dbContext.Connection.Query<CompetitionComment>("GetCompetitionComment", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }
    }
}
