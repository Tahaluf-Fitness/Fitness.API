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

        public List<ClientDTO> GetAllEmployees()
        {
            var p = new DynamicParameters();
            IEnumerable<ClientDTO> result = dbContext.Connection.Query<ClientDTO>("getAllEmployees", p, commandType: CommandType.StoredProcedure);
            return result.ToList();

        }

        public bool CreateEmployee(User user)
        {
            var p = new DynamicParameters();
            p.Add("@Username", user.Username, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@FirstName", user.FirstName, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@LastName", user.LastName, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@Email", user.Email, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@Password", user.Password, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@ConfirmPassword", user.ConfirmPassword, dbType: DbType.String, direction: ParameterDirection.Input);

            p.Add("@Gender", user.Gender, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@PhoneNumber1", user.PhoneNumber1, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@DateOfBirth", user.DateOfBirth, dbType: DbType.DateTime, direction: ParameterDirection.Input);
            p.Add("@Country", user.Country, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@City", user.City, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@Position", user.Position, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@Salary", user.Salary, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@RoleID", user.RoleId, dbType: DbType.Int32, direction: ParameterDirection.Input);

            var result = dbContext.Connection.ExecuteAsync("createUser", p, commandType: CommandType.StoredProcedure);

            return true;

        }

        public List<ClientDTO> GetAllClients()
        {
            var p = new DynamicParameters();
            IEnumerable<ClientDTO> result = dbContext.Connection.Query<ClientDTO>("getAllClients", p, commandType: CommandType.StoredProcedure);
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
