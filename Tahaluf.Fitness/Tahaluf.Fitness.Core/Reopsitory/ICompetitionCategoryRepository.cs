using System;
using System.Collections.Generic;
using System.Text;

namespace Tahaluf.Fitness.Core.Reopsitory
{
    public interface ICompetitionCategoryRepository
    {
        bool CreateCompetitionCategory(CompetioinCategory competioinCategory);
        bool UpdateCompetitionCategory(CompetioinCategory competioinCategory);
        bool DeleteCompetitionCategory(int id);
        List<CompetioinCategory> GetCompetitionCategory();




    }
}
