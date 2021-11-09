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
    public class AttendanceController : Controller
    {

        private readonly IAttendanceService attendanceService;

        public AttendanceController(IAttendanceService _attendanceService)
        {
            attendanceService = _attendanceService;
        }

        [HttpPost]
        [ProducesResponseType(typeof(Attendance), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool CreateAttendance([FromBody] Attendance attendance)
        {
            return attendanceService.CreateAttendance(attendance);
        }

        [HttpGet]
        [ProducesResponseType(typeof(List<Attendance>), StatusCodes.Status200OK)]
        public List<Attendance> GetAttendance()
        {
            return attendanceService.GetAttendance();

        }

        [HttpPut]
        [ProducesResponseType(typeof(Attendance), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool UpdateAttendance(Attendance attendance)
        {
            return attendanceService.UpdateAttendance(attendance);
        }

        [HttpDelete]
        [Route("delete/{id}")]
        [ProducesResponseType(typeof(Attendance), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool DeleteAttendance(int id)
        {
            return attendanceService.DeleteAttendance(id);
        }
    }
}
