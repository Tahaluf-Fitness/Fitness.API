using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tahaluf.Fitness.Core.Data;
using Tahaluf.Fitness.Core.Service;

namespace Tahaluf.Fitness.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BestFoodController : ControllerBase
    {
        private readonly IBestFoodService bestFoodService;

        public BestFoodController(IBestFoodService bestFoodService)
        {
            this.bestFoodService = bestFoodService;
        }

        [HttpGet]
        [ProducesResponseType(typeof(List<BestFood>), StatusCodes.Status200OK)]
        public List<BestFood> GetBestFood()
        {
            return bestFoodService.GetBestFood();
        }

        [HttpPost]
        [ProducesResponseType(typeof(BestFood), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool CreateBestFood(BestFood bestFood)
        {
            return bestFoodService.CreateBestFood(bestFood);
        }


        [HttpPut]
        [ProducesResponseType(typeof(BestFood), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool UpdateBestFood(BestFood bestFood)
        {
            return bestFoodService.UpdateBestFood(bestFood);
        }

        [HttpDelete]
        [Route("delete/{id}")]
        [ProducesResponseType(typeof(BestFood), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool DeleteBestFood(int id)
        {
            return bestFoodService.DeleteBestFood(id);
        }
    }
}
