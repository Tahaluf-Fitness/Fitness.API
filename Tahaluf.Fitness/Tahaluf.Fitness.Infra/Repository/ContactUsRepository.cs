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
    public class ContactUsRepository: IContactUsRepository
    {
        private readonly IDbContext dbContext;

        public ContactUsRepository(IDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public List<ContactUs> GetContactUs()
        {
            IEnumerable<ContactUs> result= dbContext.Connection.Query<ContactUs>("GetContactUs", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }
        public bool CreateContactUs(ContactUs contact)
        {
            var parameter = new DynamicParameters();
            parameter.Add("@Name", contact.Name, dbType: DbType.String, direction: ParameterDirection.Input);
            parameter.Add("@Email", contact.Name, dbType: DbType.String, direction: ParameterDirection.Input);
            parameter.Add("@Subject", contact.Name, dbType: DbType.String, direction: ParameterDirection.Input);
            parameter.Add("@Message", contact.Name, dbType: DbType.String, direction: ParameterDirection.Input);
            var result = dbContext.Connection.ExecuteAsync("CreateContactUs", parameter, commandType: CommandType.StoredProcedure);
            return true;
        }
        public bool UpdateContactUs(ContactUs contact)
        {
            var parameter = new DynamicParameters();
            parameter.Add("@ContactID", contact.ContactId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            parameter.Add("@Name",contact.Name,dbType:DbType.String,direction:ParameterDirection.Input);
            parameter.Add("@Email", contact.Email, dbType: DbType.String, direction: ParameterDirection.Input);
            parameter.Add("@Subject", contact.Subject, dbType: DbType.String, direction: ParameterDirection.Input);
            parameter.Add("@Message", contact.Message, dbType: DbType.String, direction: ParameterDirection.Input);
            var result = dbContext.Connection.ExecuteAsync("UpdateContactUs", parameter, commandType: CommandType.StoredProcedure);
            return true;
        }
        public bool DeleteContactUs(int id)
        {
            var parameter = new DynamicParameters();
            parameter.Add("@ContactID",id,dbType:DbType.Int32,direction:ParameterDirection.Input);
            var result = dbContext.Connection.ExecuteAsync("DeleteContactUs",parameter,commandType:CommandType.StoredProcedure);
            return true; 
        }
       


    }
}
