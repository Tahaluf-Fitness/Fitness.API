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
    public class CompetitionRepository: ICompetitionRepository
    {
        private readonly IDbContext dbContext;

        public CompetitionRepository(IDbContext _dbContext)
        {
            dbContext = _dbContext;
        }

        public bool UpdateCompetition(Competition competition)
        {
            var p = new DynamicParameters();
            p.Add("@CompetitionName", competition.CompetitionName, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@CompetitionImage", competition.CompetitionImage, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@Description", competition.Description, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@StartTime", competition.StartTime, dbType: DbType.Date, direction: ParameterDirection.Input);
            p.Add("@EndTime", competition.EndTime, dbType: DbType.Date, direction: ParameterDirection.Input);
            p.Add("@TotalMembers", competition.TotalMembers, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@WinnerName", competition.WinnerName, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@CompetitionCategoryID", competition.CompetitionCategoryID, dbType: DbType.Int32, direction: ParameterDirection.Input);

            var result = dbContext.Connection.ExecuteAsync("UpdateCompetition", p, commandType: CommandType.StoredProcedure);
            return true;
        }
        public bool CreateCompetition(Competition competition)
        {
            var p = new DynamicParameters();
            p.Add("@CompetitionName", competition.CompetitionName, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@CompetitionImage", competition.CompetitionImage, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@Description", competition.Description, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@StartTime", competition.StartTime, dbType: DbType.Date, direction: ParameterDirection.Input);
            p.Add("@EndTime", competition.EndTime, dbType: DbType.Date, direction: ParameterDirection.Input);
            p.Add("@TotalMembers", competition.TotalMembers, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@WinnerName", competition.WinnerName, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@CompetitionCategoryID", competition.CompetitionCategoryID, dbType: DbType.Int32, direction: ParameterDirection.Input);

            var result = dbContext.Connection.ExecuteAsync("CreateCompetition", p, commandType: CommandType.StoredProcedure);
            return true;
        }

        public bool DeleteCompetition(int id)
        {
            var p = new DynamicParameters();
            p.Add("@CompetitionID", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = dbContext.Connection.ExecuteAsync("DeleteCompetition", p, commandType: CommandType.StoredProcedure);
            return true;
        }
        public List<Competition> GetCompetition()
        {
            IEnumerable<Competition> result = dbContext.Connection.Query<Competition>("GetCompetition", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public List<CompetitionCategoryDTO> SearchCompetitionByCategory(SearchCompetitionCategoryDTO searchComprtitionCategoryDTO)
        {
            var p = new DynamicParameters();
            p.Add("@CompetioinCategoryName", searchComprtitionCategoryDTO.CompetioinCategoryName, dbType: DbType.String, direction: ParameterDirection.Input);
            IEnumerable<CompetitionCategoryDTO> result = dbContext.Connection.Query<CompetitionCategoryDTO>("SearchCompetitionByCategory", p, commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public List<CompetitionCategoryDTO> SearchCompetitionByInterval(SearchCompetitionIntervalDTO searchComprtitionIntervalDTO)
        {
            var p = new DynamicParameters();
            p.Add("@StartTime", searchComprtitionIntervalDTO.StartTime, dbType: DbType.DateTime, direction: ParameterDirection.Input);
            p.Add("@EndTime", searchComprtitionIntervalDTO.EndTime, dbType: DbType.DateTime, direction: ParameterDirection.Input);

            IEnumerable<CompetitionCategoryDTO> result = dbContext.Connection.Query<CompetitionCategoryDTO>("SearchCompetitionByInterval", p, commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public List<CompetitionCategoryDTO> SearchCompetitionByName(SearchCompetitionNameDTO searchComprtitionNameDTO)
        {
            var p = new DynamicParameters();
            p.Add("@CompetitionName", searchComprtitionNameDTO.CompetitionName, dbType: DbType.String, direction: ParameterDirection.Input);

            IEnumerable<CompetitionCategoryDTO> result = dbContext.Connection.Query<CompetitionCategoryDTO>("SearchCompetitionByName", p, commandType: CommandType.StoredProcedure);
            return result.ToList();
        }
    }
}
