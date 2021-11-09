using System;
using System.Collections.Generic;
using System.Text;
using Tahaluf.Fitness.Core.DTO;
using Tahaluf.Fitness.Data;

namespace Tahaluf.Fitness.Core.Service
{
   public interface IJwtService
    {
        //public List<AuthDTO> GetAuth(LoginDTO loginDTO);
        public string Auth(LoginDTO loginDTO);

    }
}
