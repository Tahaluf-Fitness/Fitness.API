using Dapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using Tahaluf.Fitness.Core.Common;
using Tahaluf.Fitness.Core.Reopsitory;
using Tahaluf.Fitness.Data;
using Tahaluf.Fitness.Infra.Common;

namespace Tahaluf.Fitness.Infra.Repository
{
    public  class ReviewRepository : IReviewRepository
    {
        private readonly IDbContext _DbContext;
        public ReviewRepository(IDbContext _DbContext) 
        {
            this._DbContext = _DbContext;
        }
        public bool CreateReview(Review review)
        {
            var p = new DynamicParameters();
            p.Add("@ReviewValue", review.ReviewValue, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@Name", review.Name, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@Status", review.Status, dbType: DbType.Boolean, direction: ParameterDirection.Input);
            p.Add("@Comment", review.Comment, dbType: DbType.String, direction: ParameterDirection.Input);
            var result = _DbContext.Connection.ExecuteAsync("CreateReview", p, commandType: CommandType.StoredProcedure);
            return true;

        }
       

        public bool DeleteReview(int id)
        {
            var p = new DynamicParameters();
            p.Add("@ReviewId", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = _DbContext.Connection.ExecuteAsync("DeleteReview", p, commandType: CommandType.StoredProcedure);

            return true;
        }

        public List<Review> GetReview()
        {
            IEnumerable<Review> result = _DbContext.Connection.Query<Review>("GetReview", CommandType.StoredProcedure);
            return result.ToList();
        }

        public List<Review> GetCheckedReview()
        {
            IEnumerable<Review> result = _DbContext.Connection.Query<Review>("GetCheckedReview", CommandType.StoredProcedure);
            return result.ToList();
        }

        public bool UpdateReview(Review review)
        {
            var p = new DynamicParameters();
            p.Add("@ReviewId", review.ReviewId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@ReviewValue", review.ReviewValue, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@Name", review.Name, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@Status", review.Status, dbType: DbType.Binary, direction: ParameterDirection.Input);
            p.Add("@Comment", review.Comment, dbType: DbType.String, direction: ParameterDirection.Input);
            var result = _DbContext.Connection.ExecuteAsync("UpdateReview", p, commandType: CommandType.StoredProcedure);

            return true;
        }

        public bool updateReviewStatus(int id,Review review)
        {
            var p = new DynamicParameters();
            p.Add("@ReviewId", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@Status", review.Status, dbType: DbType.Boolean, direction: ParameterDirection.Input);
            var result = _DbContext.Connection.ExecuteAsync("updateReviewStatus", p, commandType: CommandType.StoredProcedure);
            return true;
        }
    }
}
