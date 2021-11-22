﻿using System;
using System.Collections.Generic;
using System.Text;
using Tahaluf.Fitness.Data;

namespace Tahaluf.Fitness.Core.Reopsitory
{
   public interface IReviewRepository
    {
        bool CreateReview(Review review);
        bool UpdateReview(Review review);
        bool DeleteReview(int id);
        List<Review> GetReview();
        public List<Review> GetCheckedReview();
        public bool updateReviewStatus(int id, Review review);



    }
}
