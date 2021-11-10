﻿using Microsoft.AspNetCore.Http;
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

        [HttpPost]
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
        public List<UserReportDTO> GetAllUserReport(int id)
        {
            return userReportsService.GetAllUserReport();
        }

        [HttpDelete]
        [Route("delete/{id}")]
        [ProducesResponseType(typeof(UserReports), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool deleteUserReport(int id)
        {
            return userReportsService.DeleteUserReport(id);
        }
    }
}