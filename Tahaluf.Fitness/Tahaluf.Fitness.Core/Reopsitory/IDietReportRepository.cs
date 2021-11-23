using System;
using System.Collections.Generic;
using System.Text;
using Tahaluf.Fitness.Core.DTO;
using Tahaluf.Fitness.Data;

namespace Tahaluf.Fitness.Core.Reopsitory
{
    public interface IDietReportRepository
    {
        public List<DietReportDTO> GetDietReport();
        public bool CreateDietReport(DietReport dietReport);
        public bool UpdateDietReport(DietReport dietReport);
        public bool DeleteDietReport(int id);
        public List<getDietInfoDTO> SearchDietnByCategory(string categoryName);



    }
}
