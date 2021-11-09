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
    public class CompetitionCommentController : Controller
    {

        private readonly ICompetitionCommentService competitionCommentService;

        public CompetitionCommentController(ICompetitionCommentService _competitionCommentService)
        {
            competitionCommentService = _competitionCommentService;
        }

        [HttpPost]
        [ProducesResponseType(typeof(CompetitionComment), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool CreateCompetitionComment([FromBody] CompetitionComment competitionComment)
        {
            return competitionCommentService.CreateCompetitionComment(competitionComment);
        }

        [HttpGet]
        [ProducesResponseType(typeof(CompetitionComment), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public List<CompetitionComment> GetCompetitionComment()
        {
            return competitionCommentService.GetCompetitionComment();
        }

        [HttpPut]
        [ProducesResponseType(typeof(CompetitionComment), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool UpdateCompetitionComment(CompetitionComment competitionComment)
        {
            return competitionCommentService.UpdateCompetitionComment(competitionComment);
        }

        [HttpDelete]
        [Route("delete/{id}")]
        [ProducesResponseType(typeof(CompetitionComment), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool DeleteCompetitionComment(int id)
        {
            return competitionCommentService.DeleteCompetitionComment(id);
        }
    }
}
