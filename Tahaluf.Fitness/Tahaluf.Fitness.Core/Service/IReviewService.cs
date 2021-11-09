using System;
using System.Collections.Generic;
using System.Text;
using Tahaluf.Fitness.Data;

namespace Tahaluf.Fitness.Core.Service
{
   public interface IReviewService
    {
        bool CreateReview(Review review);
        bool UpdateReview(Review review);
        bool DeleteReview(int id);
        List<Review> GetReview();

    }
}
