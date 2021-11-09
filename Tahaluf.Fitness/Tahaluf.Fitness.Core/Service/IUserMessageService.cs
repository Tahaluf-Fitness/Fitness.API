using System;
using System.Collections.Generic;
using System.Text;
using Tahaluf.Fitness.Data;

namespace Tahaluf.Fitness.Core.Service
{
   public interface IUserMessageService
    {
       public bool CreateUserMessages(UserMessage userMessages);
       public bool UpdateUserMessages(UserMessage userMessages);
       public bool DeleteUserMessages(int id);
        List<UserMessage> GetUserMessages();
    }
}
