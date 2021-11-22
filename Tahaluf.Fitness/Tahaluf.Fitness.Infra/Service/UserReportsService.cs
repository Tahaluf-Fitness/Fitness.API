using System;
using System.Collections.Generic;
using System.Text;
using Tahaluf.Fitness.Core.DTO;
using Tahaluf.Fitness.Core.Reopsitory;
using Tahaluf.Fitness.Core.Service;

namespace Tahaluf.Fitness.Infra.Service
{
    public class UserReportsService: IUserReportsService
    {
        private readonly IUserReportsRepository userReportsRepository;

        public UserReportsService(IUserReportsRepository _userReportsRepository)
        {
            userReportsRepository = _userReportsRepository;
        }

        public List<UserReportDTO> GetUserReportByID(int id)
        {
            return userReportsRepository.GetUserReportByID(id);
        }

        public bool DeleteUserReport(int id)
        {
            return userReportsRepository.DeleteUserReport(id);
        }

        public List<UserReportDTO> GetAllUserReport()
        {
            return userReportsRepository.GetAllUserReport();
        }

        public List<ReportDTO> GetAllDietReport()
        {
            return userReportsRepository.GetAllDietReport();
        }




    }
}
