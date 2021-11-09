using System;
using System.Collections.Generic;
using System.Text;
using Tahaluf.Fitness.Data;

namespace Tahaluf.Fitness.Core.Service
{
   public interface IUserCompetitionService
    {
        bool CreateUserCompetition(UserCompetition userCompetition);
        bool UpdateUserCompetition(UserCompetition userCompetition);
        bool DeleteUserCompetition(int id);
        public List<UserCompetition> GetUserCompetition();
    }
}
