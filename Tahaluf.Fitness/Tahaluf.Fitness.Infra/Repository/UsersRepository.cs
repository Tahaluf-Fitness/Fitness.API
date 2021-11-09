using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using Tahaluf.Fitness.Core.Common;
using Tahaluf.Fitness.Core.DTO;
using Tahaluf.Fitness.Core.Reopsitory;
using Tahaluf.Fitness.Data;

namespace Tahaluf.Fitness.Infra.Repository
{
    public class UsersRepository:IUsersRepository
    {

        private readonly IDbContext dbContext;

        public UsersRepository(IDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public List<ClientDTO> GetClientInfo(int id)
        {
            var p = new DynamicParameters();
            p.Add("@UserID", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            IEnumerable<ClientDTO> result = dbContext.Connection.Query<ClientDTO>("getUserInfoByID", p, commandType: CommandType.StoredProcedure);
            return result.ToList();

        }

        public bool DeleteUser(int id)
        {
            var p = new DynamicParameters();
            p.Add("@UserID", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = dbContext.Connection.ExecuteAsync("DeleteUser", p, commandType: CommandType.StoredProcedure);

            return true;
        }


    }
}
