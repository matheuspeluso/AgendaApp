using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaApp.Domain.Interfaces.Security
{
    /// <summary>
    /// Interface para definir os métodos que irão implementar
    /// a geração do TOKEN JWT para autenticação dos usuários
    /// </summary>
    public interface IJwtBearerSecurity
    {
        /// <summary>
        /// Método para gerar a data e hora de expiração do token JWT.
        /// </summary>
        DateTime GetExpirationDate();

        /// <summary>
        /// Método para gerar o TOKEN JWT.
        /// </summary>
        string GenerateToken(string userName, string role);
    }
}



