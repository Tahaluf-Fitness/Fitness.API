using System;
using System.Collections.Generic;
using System.Text;
using Tahaluf.Fitness.Core.DTO;
using Tahaluf.Fitness.Core.Reopsitory;
using Tahaluf.Fitness.Core.Service;
using Tahaluf.Fitness.Data;

namespace Tahaluf.Fitness.Infra.Service
{
    public class DietReportService: IDietReportService
    {
        private readonly IDietReportRepository dietReportRepository;

        public DietReportService(IDietReportRepository dietReportRepository)
        {
            this.dietReportRepository = dietReportRepository;
        }

        public List<DietReportDTO> GetDietReport()
        {
            return dietReportRepository.GetDietReport();
        }
        public bool CreateDietReport(DietReport dietReport)
        {
            return dietReportRepository.CreateDietReport(dietReport);
        }
        public bool UpdateDietReport(DietReport dietReport)
        {
            return dietReportRepository.UpdateDietReport(dietReport);
        }
        public bool DeleteDietReport(int id)
        {
            return dietReportRepository.DeleteDietReport(id);
        }
        public List<getDietInfoDTO> SearchDietnByCategory(string categoryName)
        {
            return dietReportRepository.SearchDietnByCategory(categoryName);
        }




    }
}
