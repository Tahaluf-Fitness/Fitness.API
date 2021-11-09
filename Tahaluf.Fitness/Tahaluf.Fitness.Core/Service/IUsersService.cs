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
        public bool DeleteUser(int id);


    }
}
