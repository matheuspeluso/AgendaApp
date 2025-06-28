using AgendaApp.Domain.Entities;

namespace AgendaApp.Domain.Interfacies.Repositories
{
    /// <summary>
    /// Contrato de métodos para o repositório de usuário
    /// </summary>
    public interface IUsuarioRepository
    {
        void Add(Usuario usuario);

        Usuario? Find(Guid id);

        Usuario? Find(string email, string senha);

        bool Any(string email);
    }
}