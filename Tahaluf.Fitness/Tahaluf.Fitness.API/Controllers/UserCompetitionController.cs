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
    public class UserCompetitionController : Controller
    {
        private readonly IUserCompetitionService userCompetitionService;
        public UserCompetitionController(IUserCompetitionService _userCompetitionService)
        {
            userCompetitionService = _userCompetitionService;
        }

        [HttpGet]
        [ProducesResponseType(typeof(List<UserCompetition>), StatusCodes.Status200OK)]
        public List<UserCompetition> GetUserCompetition()
        {
            return userCompetitionService.GetUserCompetition();
        }

        [HttpPost]
        [ProducesResponseType(typeof(UserCompetition), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool CreateUserCompetition(UserCompetition userCompetition)
        {
            return userCompetitionService.CreateUserCompetition(userCompetition);
        }

        [HttpPut]
        [ProducesResponseType(typeof(UserCompetition), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public bool UpdateUserCompetition(UserCompetition userCompetition)
        {
            return userCompetitionService.UpdateUserCompetition(userCompetition);
        }

        [HttpDelete]
        [Route("delete/{id}")]
        [ProducesResponseType(typeof(UserCompetition), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool DeleteUserCompetition(int id)
        {
            return userCompetitionService.DeleteUserCompetition(id);
        }

    }
}
