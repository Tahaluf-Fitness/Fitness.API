using System;
using System.Collections.Generic;
using System.Text;
using Tahaluf.Fitness.Core.DTO;
using Tahaluf.Fitness.Data;

namespace Tahaluf.Fitness.Core.Reopsitory
{
    public interface IJwtRepository
    {
        //public List<AuthDTO> Auth(LoginDTO login);
        public AuthDTO Auth(LoginDTO login);

    }
}
