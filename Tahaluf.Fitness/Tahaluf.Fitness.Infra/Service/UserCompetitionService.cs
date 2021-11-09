using System;
using System.Collections.Generic;
using System.Text;
using Tahaluf.Fitness.Core.Reopsitory;
using Tahaluf.Fitness.Core.Service;
using Tahaluf.Fitness.Data;

namespace Tahaluf.Fitness.Infra.Service
{
    public class UserCompetitionService : IUserCompetitionService
    {
        private readonly IUserCompetitionRepository userCompetitionRepository;
        public UserCompetitionService(IUserCompetitionRepository _userCompetitionRepository)
        {
            userCompetitionRepository = _userCompetitionRepository;
        }
        public bool CreateUserCompetition(UserCompetition userCompetition)
        {
            return userCompetitionRepository.CreateUserCompetition(userCompetition);
        }

        public bool DeleteUserCompetition(int id)
        {
            return userCompetitionRepository.DeleteUserCompetition(id);
        }

        public List<UserCompetition> GetUserCompetition()
        {
            return userCompetitionRepository.GetUserCompetition();
        }

        public bool UpdateUserCompetition(UserCompetition userCompetition)
        {
            return userCompetitionRepository.UpdateUserCompetition(userCompetition);
        }
    }
}
