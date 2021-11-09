using System;
using System.Collections.Generic;
using System.Text;
using Tahaluf.Fitness.Core.Reopsitory;
using Tahaluf.Fitness.Core.Service;
using Tahaluf.Fitness.Data;

namespace Tahaluf.Fitness.Infra.Service
{
   public class UserMessageService : IUserMessageService
    {
        private readonly IUserMessagesRepository userMessagesRepository;
        public UserMessageService(IUserMessagesRepository _userMessagesRepository)
        {
            userMessagesRepository = _userMessagesRepository;
        }
       public bool CreateUserMessages(UserMessage userMessages)
        {
            return userMessagesRepository.CreateUserMessages(userMessages);

        }
       public bool UpdateUserMessages(UserMessage userMessages)
        {
            return userMessagesRepository.UpdateUserMessages(userMessages);

        }
        public bool DeleteUserMessages(int id)
        {
            return userMessagesRepository.DeleteUserMessages(id);
        }

        public List<UserMessage> GetUserMessages()
        {
            return userMessagesRepository.GetUserMessages();
        }
    }
}
