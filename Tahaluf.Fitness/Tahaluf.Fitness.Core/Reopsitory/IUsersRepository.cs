using System;
using System.Collections.Generic;
using System.Text;
using Tahaluf.Fitness.Core.DTO;
using Tahaluf.Fitness.Data;

namespace Tahaluf.Fitness.Core.Reopsitory
{
    public interface IUsersRepository
    {
        public List<ClientDTO> GetClientInfo(int id);

    }
}
