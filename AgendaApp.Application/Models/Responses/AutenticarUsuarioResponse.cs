using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaApp.Application.Models.Responses
{
    public class AutenticarUsuarioResponse
    {
        public required Guid Id { get; set; }
        public required string Nome { get; set; }
        public required string Email { get; set; }
        public required DateTime DataHoraAcesso { get; set; }
        public required string Token { get; set; }

    }
}
