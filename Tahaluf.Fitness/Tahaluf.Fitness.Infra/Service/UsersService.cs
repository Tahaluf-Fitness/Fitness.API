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

        public bool DeleteUser(int id)
        {
            return usersRepository.DeleteUser(id);
        }

    }
}
