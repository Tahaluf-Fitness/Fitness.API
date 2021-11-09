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
    public class JwtController : Controller
    {
        private readonly IJwtService jwtService;
        public JwtController(IJwtService _jwtService)
        {
            jwtService = _jwtService;
        }

        [HttpPost]
        public IActionResult Authen([FromBody] LoginDTO loginDTO)
        {
            var token = jwtService.Auth(loginDTO);
            if (token == null)
            {
                return Unauthorized();

            }
            else
            {
                return Ok(token);

            }


        }

        //[HttpPost]
        //[ProducesResponseType(typeof(List<AuthDTO>), StatusCodes.Status200OK)]
        //[ProducesResponseType(StatusCodes.Status400BadRequest)]
        //public List<AuthDTO> GetAuth(LoginDTO loginDTO)
        //{
        //    return jwtService.Auth(loginDTO);
        //}
    }
}
