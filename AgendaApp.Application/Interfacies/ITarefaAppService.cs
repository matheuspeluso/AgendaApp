using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AgendaApp.Application.Models.Requests;
using AgendaApp.Application.Models.Responses;

namespace AgendaApp.Application.Interfacies
{
    public interface ITarefaAppService
    {
        TarefaResponse Criar(TarefaRequest request);

        TarefaResponse Alterar(Guid id, TarefaRequest request, Guid usuarioId);

        TarefaResponse Excluir(Guid id, Guid usuarioId);

        List<TarefaResponse> Consultar(DateOnly dataMin, DateOnly dataMax, Guid usuarioId);

        TarefaResponse? Obter(Guid id, Guid usuarioId);

    }
}
