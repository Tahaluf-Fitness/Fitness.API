using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tahaluf.Fitness.Core;
using Tahaluf.Fitness.Core.Service;

namespace Tahaluf.Fitness.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompetitionCategoryController : ControllerBase
    {
        private readonly ICompetitionCategoryService competioinCategoryService;

        public CompetitionCategoryController(ICompetitionCategoryService _competioinCategoryService)
        {
            competioinCategoryService = _competioinCategoryService;
        }

        [HttpPost]
        [ProducesResponseType(typeof(CompetioinCategory), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool CreateCompetioinCategory([FromBody] CompetioinCategory competioinCategory)
        {
            return competioinCategoryService.CreateCompetitionCategory(competioinCategory);
        }

        [HttpGet]
        [ProducesResponseType(typeof(CompetioinCategory), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public List<CompetioinCategory> GetCompetioinCategory()
        {
            return competioinCategoryService.GetCompetitionCategory();
        }

        [HttpPut]
        [ProducesResponseType(typeof(CompetioinCategory), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool UpdateCompetitionCategory(CompetioinCategory competioinCategory)
        {
            return competioinCategoryService.UpdateCompetitionCategory(competioinCategory);
        }

        [HttpDelete]
        [Route("delete/{id}")]
        [ProducesResponseType(typeof(CompetioinCategory), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool DeleteCompetitionCategory(int id)
        {
            return competioinCategoryService.DeleteCompetitionCategory(id);
        }
    }
}
