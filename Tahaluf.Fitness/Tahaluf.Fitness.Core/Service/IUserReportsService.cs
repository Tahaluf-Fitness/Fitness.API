using System;
using System.Collections.Generic;
using System.Text;
using Tahaluf.Fitness.Core.DTO;

namespace Tahaluf.Fitness.Core.Service
{
    public interface IUserReportsService
    {
        public List<UserReportDTO> GetUserReportByID(int id);
        public bool DeleteUserReport(int id);
        public List<UserReportDTO> GetAllUserReport();



    }
}
