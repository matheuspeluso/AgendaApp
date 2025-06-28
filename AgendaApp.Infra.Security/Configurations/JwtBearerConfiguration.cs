using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaApp.Infra.Security.Configurations
{
    /// <summary>
    /// Classe para configurar os parametros de geração do TOKEN JWT
    /// </summary>
    public class JwtBearerConfiguration
    {
        /// <summary>
        /// Chave secreta utilizada para gerar o token JWT.
        /// </summary>
        public static string SecretKey => "";

        /// <summary>
        /// Tempo de expiração do token JWT em minutos.
        /// </summary>
        public static int ExpirationInMinutes => 60;
    }
}