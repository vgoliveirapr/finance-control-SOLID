using FinanceControl.Application.Interfaces;
using FinanceControl.Domain.DTOs;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace FinanceControl.Application.Services
{
    public class JwtService : IJwtService
    {
        private readonly IConfiguration _config;

        public JwtService(IConfiguration config)
        {
            _config = config;
        }

        public string GenerateToken(UserDTO user)
        {
            string key = _config["Jwt:Key"];
            string issuer = _config["Jwt:Issuer"];
            string audience = _config["Jwt:Audience"];

            SymmetricSecurityKey securityKey = new (Encoding.UTF8.GetBytes(key));
            SigningCredentials signingCredentials = new (securityKey, SecurityAlgorithms.HmacSha256);

            Claim[] claims =
            [
                new (JwtRegisteredClaimNames.Sub, user.Username),
                new ("name", user.Name),
                new (JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
            ];

            JwtSecurityToken token = new (
                issuer,
                audience,
                claims,
                expires: DateTime.Now.AddHours(2),
                signingCredentials: signingCredentials
            );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
