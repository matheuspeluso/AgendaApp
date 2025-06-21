using AgendaApp.Domain.Entities;

namespace AgendaApp.Domain.Interfacies
{
    /// <summary>
    /// Contrato de métodos para o repositorio de tarefa
    /// </summary>
    public interface ITarefaRepository
    {
        void Add(Tarefa tarega);

        void Update(Tarefa tarega);

        void Delete(Guid id);

        List<Tarefa> FindAll(DateOnly dataMin, DateOnly dataMax, Guid usuarioId);
        Tarefa? FindById(Guid id, Guid usuarioId);
    }
}
