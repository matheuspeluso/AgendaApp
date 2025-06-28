using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaApp.Application.Models.Requests
{
    public class TarefaRequest
    {
        public required string Nome { get; set; }
        public required string Data { get; set; }
        public required string Hora { get; set; }
        public required int Prioridade { get; set; }
    }
}
