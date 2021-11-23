using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tahaluf.Fitness.Core.DTO;
using Tahaluf.Fitness.Core.Service;
using Tahaluf.Fitness.Data;

namespace Tahaluf.Fitness.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : Controller
    {
        private readonly IUsersService usersService;
        public UserController(IUsersService _usersService)
        {
            usersService = _usersService;
        }

        [HttpGet]
        [Route("profile/{id}")]
        [ProducesResponseType(typeof(List<ClientDTO>), StatusCodes.Status200OK)]
        public List<ClientDTO> profile(int id)
        {
            return usersService.GetClientInfo(id);
        }

        [HttpGet]
        [Route("[action]")]
        [ProducesResponseType(typeof(List<ClientDTO>), StatusCodes.Status200OK)]
        public List<ClientDTO> GetAllEmployees()
        {
            return usersService.GetAllEmployees();
        }
        [HttpGet]
        [Route("[action]")]
        [ProducesResponseType(typeof(List<ClientDTO>), StatusCodes.Status200OK)]
        public List<ClientDTO> GetAllClients()
        {
            return usersService.GetAllClients();
        }
        [HttpGet]
        [Route("[action]")]
        [ProducesResponseType(typeof(List<StatisticsDTO>), StatusCodes.Status200OK)]
        public List<StatisticsDTO> getStatistics()
        {
            return usersService.getStatistics();
        }

        [HttpPost]
        [ProducesResponseType(typeof(User), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool CreateEmployee(User user)
        {
            return usersService.CreateEmployee(user);
        }

        [HttpPut]
        [Route("update/{id}")]
        [ProducesResponseType(typeof(User), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool updateUserByID(int id,User user)
        {
            return usersService.updateUserByID(id,user);
        }


        [HttpDelete]
        [Route("delete/{id}")]
        [ProducesResponseType(typeof(User), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool DeleteUser(int id)
        {
            return usersService.DeleteUser(id);
        }

        [HttpGet]
        [Route("search/{firstName}")]
        [ProducesResponseType(typeof(List<ClientDTO>), StatusCodes.Status200OK)]
        public List<ClientDTO> searchUserByFirstname(string firstName)
        {
            return usersService.searchUserByFirstname(firstName);
        }

        [HttpGet]
        [Route("search1/{firstName}")]
        [ProducesResponseType(typeof(List<ClientDTO>), StatusCodes.Status200OK)]
        public List<ClientDTO> searchEmployeeByFirstname(string firstName)
        {
            return usersService.searchEmployeeByFirstname(firstName);
        }

    }
}
