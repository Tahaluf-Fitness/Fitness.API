using System;
using System.Collections.Generic;
using System.Text;
using Tahaluf.Fitness.Core.Common;
using Tahaluf.Fitness.Core.Reopsitory;
using Dapper;

using System.Data;
using System.Linq;
using Tahaluf.Fitness.Data;
using Tahaluf.Fitness.Infra.Common;
using Tahaluf.Fitness.Core.DTO;

namespace Tahaluf.Fitness.Infra.Repository
{
   public class JwtRepository : IJwtRepository
    {
        private readonly IDbContext dBContext;
        public JwtRepository(IDbContext _dBContext) 
        {
            dBContext = _dBContext;
        }
        public AuthDTO Auth(LoginDTO login)
        {
            var p = new DynamicParameters();
            p.Add("@Email", login.Email, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@Password", login.Password, dbType: DbType.String, direction: ParameterDirection.Input);
            IEnumerable<AuthDTO> result = dBContext.Connection.Query<AuthDTO>("AuthLogin", p, commandType: CommandType.StoredProcedure);
            return result.FirstOrDefault();
        }


    }
}
