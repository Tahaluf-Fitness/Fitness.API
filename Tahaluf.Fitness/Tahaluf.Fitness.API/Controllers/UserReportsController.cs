using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tahaluf.Fitness.Core.Data;
using Tahaluf.Fitness.Core.DTO;
using Tahaluf.Fitness.Core.Service;

namespace Tahaluf.Fitness.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserReportsController : Controller
    {

        private readonly IUserReportsService userReportsService;

        public UserReportsController(IUserReportsService _userReportsService)
        {
            userReportsService = _userReportsService;
        }

        [HttpGet]
        [Route("my-reports/{id}")]
        [ProducesResponseType(typeof(UserReportDTO), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public List<UserReportDTO> GetUserReportByID(int id)
        {
            return userReportsService.GetUserReportByID(id);
        }
        [HttpGet]
        [ProducesResponseType(typeof(UserReportDTO), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public List<UserReportDTO> GetAllUserReport()
        {
            return userReportsService.GetAllUserReport();
        }

        [HttpPost]
        [ProducesResponseType(typeof(UserReports), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool CreateUserReport(UserReports userReports)
        {
            return userReportsService.CreateUserReport(userReports);
        }



        [HttpDelete]
        [Route("delete/{id}")]
        [ProducesResponseType(typeof(UserReports), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool deleteUserReport(int id)
        {
            return userReportsService.DeleteUserReport(id);
        }

        [HttpGet]
        [Route("search/{email}")]
        [ProducesResponseType(typeof(List<SearchDietByUserEmailDTO>), StatusCodes.Status200OK)]
        public List<SearchDietByUserEmailDTO> SearchDietByUserEmailDTO(string email)
        {
            return userReportsService.SearchDietByUserEmailDTO(email);
        }
    }
}
