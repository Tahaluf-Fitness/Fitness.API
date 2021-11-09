﻿using Microsoft.AspNetCore.Http;
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

    }
}
