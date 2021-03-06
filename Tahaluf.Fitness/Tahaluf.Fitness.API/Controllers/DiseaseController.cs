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
    public class DiseaseController : ControllerBase
    {
        private readonly IDiseaseService diseaseService;

        public DiseaseController(IDiseaseService diseaseService)
        {
            this.diseaseService = diseaseService;
        }
        [HttpGet]
        [ProducesResponseType(typeof(List<Disease>), StatusCodes.Status200OK)]
        public List<Disease> GetDisease()
        {
            return diseaseService.GetDisease();
        }
        [HttpPost]
        [Route("my-diseases/{id}")]
        [ProducesResponseType(typeof(List<Disease>), StatusCodes.Status200OK)]
        public List<Disease> GetDiseaseByUserID(int id)
        {
            return diseaseService.GetDiseaseByUserID(id);
        }

        [HttpPost]
        [ProducesResponseType(typeof(List<Disease>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool CreateDisease([FromBody] Disease disease)
        {
            return diseaseService.CreateDisease(disease);
        }

        [HttpPut]
        [Route("update/{id}")]
        [ProducesResponseType(typeof(List<Disease>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool UpdateDisease(Disease disease,int id)
        {
            return diseaseService.UpdateDisease(disease,id);
        }

        [HttpDelete]
        [Route("delete/{id}")]
        [ProducesResponseType(typeof(List<Disease>), StatusCodes.Status200OK)]
        public bool DeleteDisease(int id)
        {
            return diseaseService.DeleteDisease(id);
        }
    }
}
