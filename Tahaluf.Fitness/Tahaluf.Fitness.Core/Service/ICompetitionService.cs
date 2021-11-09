using System;
using System.Collections.Generic;
using System.Text;
using Tahaluf.Fitness.Core.DTO;

namespace Tahaluf.Fitness.Core.Service
{
    public interface ICompetitionService
    {
        bool UpdateCompetition(Competition competition);
        bool CreateCompetition(Competition competition);
        bool DeleteCompetition(int id);
        List<Competition> GetCompetition();
        List<CompetitionCategoryDTO> SearchCompetitionByCategory(SearchCompetitionCategoryDTO searchCompetitionCategoryDTO);
        List<CompetitionCategoryDTO> SearchCompetitionByInterval(SearchCompetitionIntervalDTO searchCompetitionIntervalDTO);

        List<CompetitionCategoryDTO> SearchCompetitionByName(SearchCompetitionNameDTO searchCompetitionNameDTO);

    }
}
