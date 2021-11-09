using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using Tahaluf.Fitness.Core;
using Tahaluf.Fitness.Core.Common;
using Tahaluf.Fitness.Core.DTO;
using Tahaluf.Fitness.Core.Reopsitory;

namespace Tahaluf.Fitness.Infra.Repository
{
    public class CompetitionCategoryRepository: ICompetitionCategoryRepository
    {
        private readonly IDbContext dbContext;

        public CompetitionCategoryRepository(IDbContext _dbContext)
        {
            dbContext = _dbContext;
        }

        public bool CreateCompetitionCategory(CompetioinCategory competioinCategory)
        {
            var p = new DynamicParameters();
            p.Add("@CompetioinCategoryName", competioinCategory.CompetioinCategoryName, dbType: DbType.String, direction: ParameterDirection.Input);          
            var result = dbContext.Connection.ExecuteAsync("CreateCompetitionCategory", p, commandType: CommandType.StoredProcedure);
            return true;
        }
        public bool UpdateCompetitionCategory(CompetioinCategory competioinCategory)
        {
            var p = new DynamicParameters();
            p.Add("@CompetioinCategoryName", competioinCategory.CompetioinCategoryName, dbType: DbType.String, direction: ParameterDirection.Input);
            var result = dbContext.Connection.ExecuteAsync("UpdateCompetitionCategory", p, commandType: CommandType.StoredProcedure);
            return true;
        }
        public bool DeleteCompetitionCategory(int id)
        {
            var p = new DynamicParameters();
            p.Add("@CompetitionCategoryID",id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = dbContext.Connection.ExecuteAsync("DeleteCompetitionCategory", p, commandType: CommandType.StoredProcedure);
            return true;
        }

        public List<CompetioinCategory> GetCompetitionCategory()
        {
            IEnumerable<CompetioinCategory> result = dbContext.Connection.Query<CompetioinCategory>("GetCompetitionCategory", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

     
    }
}
