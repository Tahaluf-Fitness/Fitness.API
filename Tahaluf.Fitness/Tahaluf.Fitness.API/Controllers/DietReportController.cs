using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tahaluf.Fitness.Core.DTO;
using System.IO;
using Tahaluf.Fitness.Core.Service;
using Tahaluf.Fitness.Data;

namespace Tahaluf.Fitness.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DietReportController : Controller
    {
        private readonly IDietReportService dietReportService;
        public DietReportController(IDietReportService dietReportService)
        {
            this.dietReportService = dietReportService;
        }

        [HttpGet]
        [ProducesResponseType(typeof(List<DietReport>),StatusCodes.Status200OK)]
        public List<DietReportDTO> GetDietReport()
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

        [HttpPost]
        [Route("upload")]
        public DietReport Upload()
        {
            try
            {
                var file = Request.Form.Files[0];
                using (var ms = new MemoryStream())
                {
                    file.CopyTo(ms);
                }
                var fileName = Path.GetFileNameWithoutExtension(file.FileName);


                string attachmentFileName = $"{Guid.NewGuid().ToString("N")}_{fileName}.{Path.GetExtension(file.FileName).Replace(".", "")}";
                var fullPath = Path.Combine("C:\\Users\\user\\Fitness.API\\Tahaluf.Fitness\\Tahaluf.Fitness.API\\Properties\\assets\\" + "files\\diets\\", attachmentFileName);
                var fullPath2 = Path.Combine("C:\\Users\\user\\Fitness-vs2\\Fitness\\src\\assets\\" + "doc\\uploaded\\", attachmentFileName);

                using (var stream = new FileStream(fullPath, FileMode.Create))
                {
                    file.CopyTo(stream);
                }
                using (var stream = new FileStream(fullPath2, FileMode.Create))
                {
                    file.CopyTo(stream);
                }



                return new DietReport { DietFile = attachmentFileName };
            }
            catch (Exception )
            {
                return null;
            }





        }
    }
}
