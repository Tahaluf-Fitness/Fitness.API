using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tahaluf.Fitness.Core.Service;
using Tahaluf.Fitness.Data;

namespace Tahaluf.Fitness.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReviewController : Controller
    {
        private readonly IReviewService reviewService;
        public ReviewController(IReviewService _reviewService)
        {
            reviewService = _reviewService;
        }

        [HttpGet]
        [ProducesResponseType(typeof(List<Review>), StatusCodes.Status200OK)]
        public List<Review> GetReview()
        {
            return reviewService.GetReview();
        }


        [HttpPost]
        [ProducesResponseType(typeof(Review), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool CreateReview(Review review)
        {
            return reviewService.CreateReview(review);
        }


        [HttpPut]
        [ProducesResponseType(typeof(Review), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public bool UpdateReview(Review review)
        {
            return reviewService.UpdateReview(review);
        }


        [HttpDelete]
        [Route("delete/{id}")]
        [ProducesResponseType(typeof(Review), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool DeleteReview(int id)
        {
            return reviewService.DeleteReview(id);
        }


    }
}
