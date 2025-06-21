using AgendaApp.Domain.Entities;
using AgendaApp.Domain.Interfacies;
using AgendaApp.Infra.Data.Contexts;

namespace AgendaApp.Infra.Data.Repositories
{
    public class TarefaRepository : ITarefaRepository
    {
        private readonly DataContext _dataContext;

        public TarefaRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public void Add(Tarefa tarega)
        {
            _dataContext.Add(tarega);
            _dataContext.SaveChanges();
        }

        public void Delete(Guid id)
        {
            var tarefa = _dataContext.Set<Tarefa>().Find(id);

            if (tarefa is null)
                throw new ApplicationException("Tarefa não encontrada.");

            tarefa.Ativo = false;
            _dataContext.Update(tarefa);
            _dataContext.SaveChanges();
        }

        public List<Tarefa> FindAll(DateOnly dataMin, DateOnly dataMax, Guid usuarioId)
        {
            return _dataContext.Set<Tarefa>()
                    .Where(t=> t.Ativo && t.Data >= dataMin && t.Data <= dataMax && t.UsuarioId == usuarioId)
                    .OrderByDescending(t => t.Data)
                    .ToList();
        }

        public Tarefa? FindById(Guid id, Guid usuarioId)
        {
          return _dataContext.Set<Tarefa>().Where(t=> t.Ativo && t.Id == id && t.UsuarioId==usuarioId)
                .SingleOrDefault(); // se achar mais de 1 da erro
        }

        public void Update(Tarefa tarefa)
        {
           _dataContext.Update(tarefa);
            _dataContext.SaveChanges();
        }
    }
}
