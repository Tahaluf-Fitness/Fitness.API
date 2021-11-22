using System;
using System.Collections.Generic;
using System.Text;
using Tahaluf.Fitness.Core.Common;
using Tahaluf.Fitness.Core.Reopsitory;
using Tahaluf.Fitness.Core.Service;
using Tahaluf.Fitness.Data;

namespace Tahaluf.Fitness.Infra.Service
{
   public class ReviewService : IReviewService
    {
        private readonly IReviewRepository reviewRepository;
        public ReviewService(IReviewRepository _reviewRepository)
        {
            reviewRepository = _reviewRepository;
        }

        public bool CreateReview(Review review)
        {
            return reviewRepository.CreateReview(review);
        }

        public bool DeleteReview(int id)
        {
            return reviewRepository.DeleteReview(id);
        }

        public List<Review> GetReview()
        {
            return reviewRepository.GetReview();
        }

        public List<Review> GetCheckedReview()
        {
            return reviewRepository.GetCheckedReview();
        }


        public bool UpdateReview(Review review)
        {
            return reviewRepository.UpdateReview(review);
        }

        public bool updateReviewStatus(int id,Review review)
        {
            return reviewRepository.updateReviewStatus(id, review);
        }

    }
}
