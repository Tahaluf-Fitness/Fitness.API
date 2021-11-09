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
    public class DietReportController : ControllerBase
    {
        private readonly IDietReportService dietReportService;
        public DietReportController(IDietReportService dietReportService)
        {
            this.dietReportService = dietReportService;
        }

        [HttpGet]
        [ProducesResponseType(typeof(List<DietReport>),StatusCodes.Status200OK)]
        public List<DietReport> GetDietReport()
        {
            return dietReportService.GetDietReport();
        }
        [HttpPost]
        [ProducesResponseType(typeof(List<DietReport>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public bool CreateDietReport(DietReport dietReport)
        {
            return dietReportService.CreateDietReport(dietReport);
        }


        [HttpPut]
        [ProducesResponseType(typeof(List<DietReport>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool UpdateDietReport(DietReport dietReport)
        {
            return dietReportService.UpdateDietReport(dietReport);
        }

        [HttpDelete]
        [Route("delete/{id}")]
        [ProducesResponseType(typeof(List<DietReport>), StatusCodes.Status200OK)]
        public bool DeleteDietReport(int id)
        {
            return dietReportService.DeleteDietReport(id);
        }
    }
}
