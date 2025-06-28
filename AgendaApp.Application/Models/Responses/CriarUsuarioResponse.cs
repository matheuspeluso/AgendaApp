using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaApp.Application.Models.Responses
{
    public class CriarUsuarioResponse
    {
        public required Guid Id { get; set; }
        public required string Nome { get; set; }
        public required string Email { get; set; }
        public required DateTime DataHoraCriacao { get; set; }
    }
}