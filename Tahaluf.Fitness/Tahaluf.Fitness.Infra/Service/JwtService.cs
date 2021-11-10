using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Tahaluf.Fitness.Core.DTO;
using Tahaluf.Fitness.Core.Reopsitory;
using Tahaluf.Fitness.Core.Service;
using Tahaluf.Fitness.Data;

namespace Tahaluf.Fitness.Infra.Service
{
    public class JwtService : IJwtService
    {
        private readonly IJwtRepository jwtRepository;
        public JwtService(IJwtRepository _jwtRepository)
        {
            jwtRepository = _jwtRepository;
        }
        public string Auth(LoginDTO loginDTO)
        {
            var result = jwtRepository.Auth(loginDTO);
            if (result == null)
            {
                return null;
            }
            else
            {
                var tokenHandler = new JwtSecurityTokenHandler();
                var tokenKey = Encoding.ASCII.GetBytes("[SECRET USED TO SIGN AND VERIFY JWT TOKENS, IT CAN BE ANY STRING]");
                var tokenDescriptor = new SecurityTokenDescriptor
                {
                    Subject = new ClaimsIdentity(new Claim[]
                {

                new Claim(ClaimTypes.Email, result.Email),
                new Claim(ClaimTypes.Role, result.RoleName),
                new Claim("UserID", result.UserID.ToString()),

                }),
                    Expires = DateTime.UtcNow.AddHours(1),//end session 
                    SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(tokenKey), SecurityAlgorithms.HmacSha256Signature)//algo name 
                };
                var token = tokenHandler.CreateToken(tokenDescriptor);
                return tokenHandler.WriteToken(token);
            }


        }

        //public List<AuthDTO> GetAuth(LoginDTO loginDTO)
        //{
        //    return jwtRepository.Auth(loginDTO);
        //}


    }
}
