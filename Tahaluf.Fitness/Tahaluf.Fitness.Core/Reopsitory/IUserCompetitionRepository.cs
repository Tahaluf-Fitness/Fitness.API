using System;
using System.Collections.Generic;
using System.Text;
using Tahaluf.Fitness.Data;

namespace Tahaluf.Fitness.Core.Reopsitory
{
   public interface IUserCompetitionRepository
    {
        bool CreateUserCompetition(UserCompetition userCompetition);
        bool UpdateUserCompetition(UserCompetition userCompetition);
        bool DeleteUserCompetition(int id);
        List<UserCompetition> GetUserCompetition();
    }
}
