using System;
using System.Collections.Generic;
using System.Text;
using Tahaluf.Fitness.Core.Reopsitory;
using Tahaluf.Fitness.Core.Service;
using Tahaluf.Fitness.Data;

namespace Tahaluf.Fitness.Infra.Service
{
    public class CompetitionCommentService: ICompetitionCommentService
    {
        private readonly ICompetitionCommentRepository competitionCommentRepository;

        public CompetitionCommentService(ICompetitionCommentRepository _competitionCommentRepository)
        {
            competitionCommentRepository = _competitionCommentRepository;
        }

        public bool UpdateCompetitionComment(CompetitionComment competitionComment)
        {
            return competitionCommentRepository.UpdateCompetitionComment(competitionComment);
        }
        public bool CreateCompetitionComment(CompetitionComment competitionComment)
        {
            return competitionCommentRepository.CreateCompetitionComment(competitionComment);
        }

        public bool DeleteCompetitionComment(int id)
        {
            return competitionCommentRepository.DeleteCompetitionComment(id);
        }

        public List<CompetitionComment> GetCompetitionComment()
        {
            return competitionCommentRepository.GetCompetitionComment();

        }
    }
}
