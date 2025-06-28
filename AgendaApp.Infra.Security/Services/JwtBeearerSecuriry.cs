using AgendaApp.Domain.Interfaces.Security;
using AgendaApp.Infra.Security.Configurations;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace AgendaApp.Infra.Security.Services
{
    /// <summary>
    /// Implementação para geração dos tokens JWT Bearer.
    /// </summary>
    public class JwtBearerSecurity : IJwtBearerSecurity
    {
        public DateTime GetExpirationDate()
        {
            return DateTime.UtcNow.AddMinutes(JwtBearerConfiguration.ExpirationInMinutes);
        }

        public string GenerateToken(string userName, string role)
        {
            var expiration = GetExpirationDate();

            // Chave secreta
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(JwtBearerConfiguration.SecretKey));

            // Credenciais para assinatura
            var credentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            // Claims (informações contidas no token)
            var claims = new[]
            {
                new Claim(ClaimTypes.Name, userName),
                new Claim(ClaimTypes.Role, role),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
            };

            // Criação do token
            var token = new JwtSecurityToken(
                issuer: "AgendaApp",
                audience: "AgendaAppClient",
                claims: claims,
                expires: expiration,
                signingCredentials: credentials
            );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}