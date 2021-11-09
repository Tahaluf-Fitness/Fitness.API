using System;
using System.Collections.Generic;
using System.Text;
using Tahaluf.Fitness.Data;

namespace Tahaluf.Fitness.Core.Reopsitory
{
 public   interface IUserMessagesRepository
    {
        bool CreateUserMessages(UserMessage userMessages);
        bool UpdateUserMessages(UserMessage userMessages);
        bool DeleteUserMessages(int id);
        List<UserMessage> GetUserMessages();
    }
}
