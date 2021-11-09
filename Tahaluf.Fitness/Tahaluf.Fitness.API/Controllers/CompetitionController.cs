using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tahaluf.Fitness.Core;
using Tahaluf.Fitness.Core.DTO;
using Tahaluf.Fitness.Core.Service;

namespace Tahaluf.Fitness.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompetitionController : ControllerBase
    {
        private readonly ICompetitionService competioinService;

        public CompetitionController(ICompetitionService _competioinService)
        {
            competioinService = _competioinService;
        }

        [HttpPost]
        [ProducesResponseType(typeof(Competition), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool CreateCompetition([FromBody] Competition competition )
        {
            return competioinService.CreateCompetition(competition);
        }

        [HttpGet]
        [ProducesResponseType(typeof(Competition), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public List<Competition> GetCompetition()
        {
            return competioinService.GetCompetition();
        }


        [HttpPut]
        [ProducesResponseType(typeof(Competition), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool UpdateCompetition(Competition competition)
        {
            return competioinService.UpdateCompetition(competition);
        }

        [HttpDelete]
        [Route("delete/{id}")]
        [ProducesResponseType(typeof(Competition), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool DeleteCompetition(int id)
        {
            return competioinService.DeleteCompetition(id);
        }

        [HttpPost]
        [Route("[action]")]
        [ProducesResponseType(typeof(List<CompetitionCategoryDTO>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public List<CompetitionCategoryDTO> SearchCompetioinCategory([FromBody] SearchCompetitionCategoryDTO searchCompetitionCategoryDTO)
        {
            return competioinService.SearchCompetitionByCategory(searchCompetitionCategoryDTO);
        }

        [HttpPost]
        [Route("[action]")]
        [ProducesResponseType(typeof(List<CompetitionCategoryDTO>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public List<CompetitionCategoryDTO> SearchCompetioinInterval([FromBody] SearchCompetitionIntervalDTO searchCompetitionIntervalDTO)
        {
            return competioinService.SearchCompetitionByInterval(searchCompetitionIntervalDTO);
        }

        [HttpPost]
        [Route("[action]")]
        [ProducesResponseType(typeof(List<CompetitionCategoryDTO>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public List<CompetitionCategoryDTO> SearchCompetioinName([FromBody] SearchCompetitionNameDTO searchCompetitionNameDTO)
        {
            return competioinService.SearchCompetitionByName(searchCompetitionNameDTO);
        }
    }
}
