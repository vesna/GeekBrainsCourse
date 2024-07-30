using Microsoft.IdentityModel.Tokens;
using StoreMarket004.BLL.Abstractions;
using StoreMarket004.Securities;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace StoreMarket004.BLL
{
    public class TokenService : ITokenService
    {
        private readonly JwtConfiguration _jwtConfiguration;

        public TokenService(JwtConfiguration jwtConfiguration)
        {
            _jwtConfiguration = jwtConfiguration;
        }

        public string GenerateToken(string email, string roleName)
        {
            var cred = new SigningCredentials(_jwtConfiguration.GetSingingKey(), SecurityAlgorithms.HmacSha256);

            var claims = new[]
            {
                new Claim(ClaimTypes.Email, email),
                new Claim(ClaimTypes.Role, roleName)
            };

            var token = new JwtSecurityToken(
                issuer: _jwtConfiguration.Issuer,
                audience: _jwtConfiguration.Audience,
                claims: claims,
                expires: DateTime.Now.AddMinutes(30),
                signingCredentials: cred);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
