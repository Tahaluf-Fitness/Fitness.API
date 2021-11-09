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
    public class DietCategoryController : ControllerBase
    {
        private readonly IDietCategoryService dietCategoryService;

        public DietCategoryController(IDietCategoryService dietCategoryService)
        {
            this.dietCategoryService = dietCategoryService;
        }


        [HttpGet]
        [ProducesResponseType(typeof(List<DietCategory>), StatusCodes.Status200OK)]
        public List<DietCategory> GetDietCategory()
        {
            return dietCategoryService.GetDietCategory();
        }

        [HttpPost]
        [ProducesResponseType(typeof(List<DietCategory>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool CreateDietCategory(DietCategory dietCategory)
        {
            return dietCategoryService.CreateDietCategory(dietCategory);
        }

        [HttpPut]
        [ProducesResponseType(typeof(List<DietCategory>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool UpdateDietCategory(DietCategory dietCategory)
        {
            return dietCategoryService.UpdateDietCategory(dietCategory);
        }

        [HttpDelete]
        [Route("delete/{id}")]
        [ProducesResponseType(typeof(List<DietCategory>), StatusCodes.Status200OK)]
        public bool DeleteDietCategory(int id)
        {
            return dietCategoryService.DeleteDietCategory(id);
        }
    }
}
