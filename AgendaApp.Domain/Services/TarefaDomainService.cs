using AgendaApp.Domain.Entities;
using AgendaApp.Domain.Interfaces.Services;
using AgendaApp.Domain.Interfacies.Repositories;

namespace AgendaApp.Domain.Services
{
    public class TarefaDomainService (ITarefaRepository tarefaRepository) : ITarefaDomainService
    {
        public void Atualizar(Tarefa tarefa)
        {
            if (tarefaRepository.FindById(tarefa.Id, tarefa.UsuarioId) == null)
                throw new ApplicationException("Tarefa não encontrada para edição.");

            tarefaRepository.Update(tarefa);
        }
        public void Inserir(Tarefa tarefa)
        {
            tarefaRepository.Add(tarefa);
        }
   

        public List<Tarefa> Consultar()
        {
            throw new NotImplementedException();
        }

        public Tarefa? ConsultarPorId(Guid id, Guid usuarioId)
        {
            return tarefaRepository.FindById(id, usuarioId);
        }

        public void Excluir(Guid id, Guid usuarioId)
        {
            if (tarefaRepository.FindById(id, usuarioId) == null)
                throw new ApplicationException("Tarefa não encontrada para exclusão.");

            tarefaRepository.Delete(id);
        }

        public List<Tarefa> Consultar(DateOnly dataMin, DateOnly dataMax, Guid usuarioId)
        {
            return tarefaRepository.FindAll(dataMin, dataMax, usuarioId) ?? new List<Tarefa>();
        }
    }
}