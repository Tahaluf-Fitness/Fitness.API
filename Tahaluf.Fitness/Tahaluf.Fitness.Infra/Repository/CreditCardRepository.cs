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
    public class CreditCardRepository: ICreditCardRepository
    {
        private readonly IDbContext dbContext;

        public CreditCardRepository(IDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public List<CreditCard> GetCreditCard()
        {
            IEnumerable<CreditCard> result = dbContext.Connection.Query<CreditCard>("GetCreditCard",commandType:CommandType.StoredProcedure);
            return result.ToList();
        }
        public bool CreateCreditCard(CreditCard creditCard)
        {
            var parameter = new DynamicParameters();
            parameter.Add("@Code",creditCard.Code,dbType:DbType.Int32,direction:ParameterDirection.Input);
            parameter.Add("@Password", creditCard.Password, dbType: DbType.String, direction: ParameterDirection.Input);
            parameter.Add("@ExpireDate", creditCard.ExpireDate, dbType: DbType.Date, direction: ParameterDirection.Input);
            parameter.Add("@TotalMoney", creditCard.TotalMoney, dbType: DbType.Int32, direction: ParameterDirection.Input);
            parameter.Add("@UserID", creditCard.UserId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = dbContext.Connection.ExecuteAsync("CreateCreditCard", parameter,commandType:CommandType.StoredProcedure);
            return true;
        }
        public bool UpdateCreditCard(CreditCard creditCard)
        {
            var parameter = new DynamicParameters();
            parameter.Add("@CreditCardID", creditCard.CreditCardId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            parameter.Add("@Code", creditCard.Code, dbType: DbType.Int32, direction: ParameterDirection.Input);
            parameter.Add("@Password", creditCard.Password, dbType: DbType.String, direction: ParameterDirection.Input);
            parameter.Add("@ExpireDate", creditCard.ExpireDate, dbType: DbType.Date, direction: ParameterDirection.Input);
            parameter.Add("@TotalMoney", creditCard.TotalMoney, dbType: DbType.Int32, direction: ParameterDirection.Input);
            parameter.Add("@UserID", creditCard.UserId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = dbContext.Connection.ExecuteAsync("UpdateCreditCard", parameter, commandType: CommandType.StoredProcedure);
            return true;
        }
        public bool DeleteCreditCard(int id)
        {
            var parameter = new DynamicParameters();
            parameter.Add("@CreditCardID", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = dbContext.Connection.ExecuteAsync("DeleteCreditCard", parameter, commandType: CommandType.StoredProcedure);
            return true;
        }
    }
}
