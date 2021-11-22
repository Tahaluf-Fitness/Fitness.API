using System;
using System.Collections.Generic;
using System.Text;
using Tahaluf.Fitness.Core.DTO;
using Tahaluf.Fitness.Data;

namespace Tahaluf.Fitness.Core.Service
{
    public interface IUsersService
    {

        public List<ClientDTO> GetClientInfo(int id);
        public List<ClientDTO> GetAllEmployees();

        public List<ClientDTO> GetAllClients();
        public bool DeleteUser(int id);
        public bool CreateEmployee(User user);
        public bool updateUserByID(int id, User user);
        public List<StatisticsDTO> getStatistics();





    }
}
