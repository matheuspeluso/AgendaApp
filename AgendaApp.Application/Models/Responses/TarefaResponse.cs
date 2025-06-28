using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaApp.Application.Models.Responses
{
    public class TarefaResponse
    {
        public required Guid Id { get; set; }
        public required string Nome { get; set; }
        public required string Data { get; set; }
        public required string Hora { get; set; }
        public required int Prioridade { get; set; }
    }
}
