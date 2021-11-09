using System;
using System.Collections.Generic;
using System.Text;
using Tahaluf.Fitness.Core;
using Tahaluf.Fitness.Core.Reopsitory;
using Tahaluf.Fitness.Core.Service;
using Tahaluf.Fitness.Infra.Repository;

namespace Tahaluf.Fitness.Infra.Service
{
    public class CompetitionCategoryService: ICompetitionCategoryService
    {
        private readonly ICompetitionCategoryRepository competioinCategoryRepository;

        public CompetitionCategoryService(ICompetitionCategoryRepository _competioinCategoryRepository)
        {
            competioinCategoryRepository = _competioinCategoryRepository;
        }

        public bool UpdateCompetitionCategory(CompetioinCategory competioinCategory)
        {
            return competioinCategoryRepository.UpdateCompetitionCategory(competioinCategory);
        }
        public bool CreateCompetitionCategory(CompetioinCategory competioinCategory)
        {
            return competioinCategoryRepository.CreateCompetitionCategory(competioinCategory);
        }
        public bool DeleteCompetitionCategory(int id)
        {
            return competioinCategoryRepository.DeleteCompetitionCategory(id);
        }
        public List<CompetioinCategory> GetCompetitionCategory()
        {
            return competioinCategoryRepository.GetCompetitionCategory();

        }
    }
}
