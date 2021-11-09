using System;
using System.Collections.Generic;
using System.Text;
using Tahaluf.Fitness.Core;
using Tahaluf.Fitness.Core.DTO;
using Tahaluf.Fitness.Core.Reopsitory;
using Tahaluf.Fitness.Core.Service;

namespace Tahaluf.Fitness.Infra.Service
{
    public class CompetitionService: ICompetitionService
    {
        private readonly ICompetitionRepository competitionRepository;

        public CompetitionService(ICompetitionRepository _competitionRepository)
        {
            competitionRepository = _competitionRepository;
        }

        public bool UpdateCompetition(Competition competition)
        {
            return competitionRepository.UpdateCompetition(competition);
        }
        public bool CreateCompetition(Competition competition)
        {
            return competitionRepository.CreateCompetition(competition);
        }       

        public bool DeleteCompetition(int id)
        {
            return competitionRepository.DeleteCompetition(id);
        }

        public List<Competition> GetCompetition()
        {
            return competitionRepository.GetCompetition();

        }

        public List<CompetitionCategoryDTO> SearchCompetitionByCategory(SearchCompetitionCategoryDTO searchCompetitionCategoryDTO)
        {

            return competitionRepository.SearchCompetitionByCategory(searchCompetitionCategoryDTO);
        }

        public List<CompetitionCategoryDTO> SearchCompetitionByInterval(SearchCompetitionIntervalDTO searchCompetitionIntervalDTO)
        {
            return competitionRepository.SearchCompetitionByInterval(searchCompetitionIntervalDTO);
        }

        public List<CompetitionCategoryDTO> SearchCompetitionByName(SearchCompetitionNameDTO searchCompetitionNameDTO)
        {
            return competitionRepository.SearchCompetitionByName(searchCompetitionNameDTO);
        }
    }
}
