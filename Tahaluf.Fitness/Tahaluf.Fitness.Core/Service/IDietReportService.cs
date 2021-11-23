using System;
using System.Collections.Generic;
using System.Text;
using Tahaluf.Fitness.Core.DTO;
using Tahaluf.Fitness.Data;

namespace Tahaluf.Fitness.Core.Service
{
    public interface IDietReportService
    {
        public List<DietReportDTO> GetDietReport();
        public bool CreateDietReport(DietReport dietReport);
        public bool UpdateDietReport(DietReport dietReport);
        public bool DeleteDietReport(int id);
        public List<getDietInfoDTO> SearchDietnByCategory(string categoryName);


    }
}
