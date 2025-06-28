using AgendaApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaApp.Domain.Interfaces.Services
{
    public interface ITarefaDomainService
    {
        void Inserir(Tarefa tarefa);

        void Atualizar(Tarefa tarefa);

        void Excluir(Guid id, Guid usuarioId);

        List<Tarefa> Consultar(DateOnly dataMin, DateOnly dataMax, Guid usuarioId);

        Tarefa? ConsultarPorId(Guid id, Guid usuarioId);
    }
}



