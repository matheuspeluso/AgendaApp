using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AgendaApp.Application.Interfacies;
using AgendaApp.Application.Models.Requests;
using AgendaApp.Application.Models.Responses;
using AgendaApp.Domain.Interfaces.Services;

namespace AgendaApp.Application.Services
{
    public class TarefaAppsServices (ITarefaDomainService tarefaDomainService) : ITarefaAppService
    {
        public TarefaResponse Alterar(Guid id, TarefaRequest request, Guid usuarioId)
        {
            throw new NotImplementedException();
        }

        public List<TarefaResponse> Consultar(DateOnly dataMin, DateOnly dataMax, Guid usuarioId)
        {
            throw new NotImplementedException();
        }

        public TarefaResponse Criar(TarefaRequest request)
        {
            throw new NotImplementedException();
        }

        public TarefaResponse Excluir(Guid id, Guid usuarioId)
        {
            throw new NotImplementedException();
        }

        public TarefaResponse? Obter(Guid id, Guid usuarioId)
        {
            throw new NotImplementedException();
        }
    }
}