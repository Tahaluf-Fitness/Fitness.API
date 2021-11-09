using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using Tahaluf.Fitness.Core.Common;
using Tahaluf.Fitness.Core.Reopsitory;
using Tahaluf.Fitness.Data;

namespace Tahaluf.Fitness.Infra.Repository
{
   public class UserMessagesRepository : IUserMessagesRepository
    {
        private readonly IDbContext _DbContext;
        public UserMessagesRepository(IDbContext _DbContext)
        {
            this._DbContext = _DbContext;
        }

        public bool CreateUserMessages(UserMessage userMessages)
        {
            var p = new DynamicParameters();
            p.Add("@UserId", userMessages.UserId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@MsgId", userMessages.MsgId, dbType: DbType.Int32, direction: ParameterDirection.Input);
           
           
            var result = _DbContext.Connection.ExecuteAsync("CreateUserMessages", p, commandType: CommandType.StoredProcedure);

            return true;
        }

        public bool DeleteUserMessages(int id)
        {
            var p = new DynamicParameters();
            p.Add("@UserMessageID", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = _DbContext.Connection.ExecuteAsync("DeleteUserMessages", p, commandType: CommandType.StoredProcedure);

            return true;
        }

        public List<UserMessage> GetUserMessages()
        {
            IEnumerable<UserMessage> result = _DbContext.Connection.Query<UserMessage>("GetUserMessages", CommandType.StoredProcedure);
            return result.ToList();
        }

        public bool UpdateUserMessages(UserMessage userMessages)
        {
            var p = new DynamicParameters();
            p.Add("@UserMessageId", userMessages.UserMessageId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@UserId", userMessages.UserId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@MsgId", userMessages.MsgId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = _DbContext.Connection.ExecuteAsync("UpdateUserMessages", p, commandType: CommandType.StoredProcedure);

            return true;
        }
    }
}
