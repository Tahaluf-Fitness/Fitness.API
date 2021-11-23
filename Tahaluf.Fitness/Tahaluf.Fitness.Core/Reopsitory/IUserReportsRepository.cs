using System;
using System.Collections.Generic;
using System.Text;
using Tahaluf.Fitness.Core.Data;
using Tahaluf.Fitness.Core.DTO;

namespace Tahaluf.Fitness.Core.Reopsitory
{
    public interface IUserReportsRepository
    {
        public List<UserReportDTO> GetUserReportByID(int id);
        public bool DeleteUserReport(int id);
        public List<UserReportDTO> GetAllUserReport();

        public bool CreateUserReport(UserReports userReports);
        public List<SearchDietByUserEmailDTO> SearchDietByUserEmailDTO(string email);





    }
}
