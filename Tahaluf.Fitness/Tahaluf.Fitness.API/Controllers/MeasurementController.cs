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
    public class MeasurementController : ControllerBase
    {
        private readonly IMeasurementService measurementService;

        public MeasurementController(IMeasurementService measurementService)
        {
            this.measurementService = measurementService;
        }

        [HttpGet]
        [ProducesResponseType(typeof(List<Measurement>), StatusCodes.Status200OK)]
        public List<Measurement> GetMeasurement()
        {
            return measurementService.GetMeasurement();
        }

        [HttpPost]
        [ProducesResponseType(typeof(List<Measurement>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool CreateMeasurement(Measurement measurement)
        {
            return measurementService.CreateMeasurement(measurement);
        }

        [HttpGet]
        [Route("my-measurements/{id}")]
        [ProducesResponseType(typeof(List<Measurement>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public List<Measurement> CreateMeasurementByUserID(int id)
        {
            return measurementService.GetMeasurementByUserID(id);
        }

        [HttpPut]
        [Route("update/{id}")]
        [ProducesResponseType(typeof(List<Measurement>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool UpdateMeasurement(int id, Measurement measurement)
        {
            return measurementService.UpdateMeasurement(id,measurement);
        }


        [HttpDelete]
        [Route("delete/{id}")]
        [ProducesResponseType(typeof(List<Measurement>), StatusCodes.Status200OK)]
        public bool DeleteMeasurement(int id)
        {
            return measurementService.DeleteMeasurement(id);
        }
    }
}
