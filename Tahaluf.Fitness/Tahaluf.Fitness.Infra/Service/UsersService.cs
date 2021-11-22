using System;
using System.Collections.Generic;
using System.Text;
using Tahaluf.Fitness.Core.DTO;
using Tahaluf.Fitness.Core.Reopsitory;
using Tahaluf.Fitness.Core.Service;
using Tahaluf.Fitness.Data;

namespace Tahaluf.Fitness.Infra.Service
{
    public class UsersService: IUsersService
    {
        private readonly IUsersRepository usersRepository;

        public UsersService(IUsersRepository usersRepository)
        {
            this.usersRepository = usersRepository;
        }

        public List<ClientDTO> GetClientInfo(int id)
        {
            return usersRepository.GetClientInfo(id);
        }

        public List<ClientDTO> GetAllClients()
        {
            return usersRepository.GetAllClients();
        }

        public List<ClientDTO> GetAllEmployees()
        {
            return usersRepository.GetAllEmployees();
        }

        public bool CreateEmployee(User user)
        {
            return usersRepository.CreateEmployee(user);
        }

        public bool updateUserByID(int id, User user)
        {
            return usersRepository.updateUserByID(id, user);
        }

        public List<StatisticsDTO> getStatistics()
        {
            return usersRepository.getStatistics();
        }





        public bool DeleteUser(int id)
        {
            return usersRepository.DeleteUser(id);
        }

    }
}
