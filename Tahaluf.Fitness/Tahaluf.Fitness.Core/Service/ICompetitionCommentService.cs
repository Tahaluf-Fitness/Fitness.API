using System;
using System.Collections.Generic;
using System.Text;
using Tahaluf.Fitness.Data;

namespace Tahaluf.Fitness.Core.Service
{
    public interface ICompetitionCommentService
    {
        bool UpdateCompetitionComment(CompetitionComment competitionComment);
        bool CreateCompetitionComment(CompetitionComment competitionComment);
        bool DeleteCompetitionComment(int id);
        List<CompetitionComment> GetCompetitionComment();
    }
}
