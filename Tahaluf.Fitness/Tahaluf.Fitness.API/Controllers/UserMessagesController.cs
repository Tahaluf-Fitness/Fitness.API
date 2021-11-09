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
    public class UserMessagesController : Controller
    {
        private readonly IUserMessageService userMessageService;
        public UserMessagesController(IUserMessageService _userMessageService)
        {
            userMessageService = _userMessageService;
        }

        [HttpGet]
        [ProducesResponseType(typeof(List<UserMessage>), StatusCodes.Status200OK)]
        public List<UserMessage> GetUserMessages()
        {
            return userMessageService.GetUserMessages();
        }




        [HttpPost]
        [Route("[action]")]
        [ProducesResponseType(typeof(UserMessage), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool CreateUserMessages(UserMessage userMessages)
        {
            return userMessageService.CreateUserMessages(userMessages);
        }



        [HttpPut]
        [Route("[action]")]
        [ProducesResponseType(typeof(UserMessage), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool UpdateUserMessages(UserMessage userMessages)
        {
            return userMessageService.UpdateUserMessages(userMessages);
        }

        [HttpPost]
        [Route("delete/{id}")]
        [ProducesResponseType(typeof(UserMessage), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool DeleteUserMessages(int id)
        {
            return userMessageService.DeleteUserMessages(id);

        }
    }
}
