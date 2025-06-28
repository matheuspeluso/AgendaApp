using AgendaApp.Domain.Entities;
using AgendaApp.Domain.Interfaces.Security;
using AgendaApp.Domain.Interfaces.Services;
using AgendaApp.Domain.Interfacies.Repositories;

namespace AgendaApp.Domain.Services
{
    public class UsuarioDomainService  (IUsuarioRepository usuarioRepository, IJwtBearerSecurity jwtBearerSecurity) : IUsuarioDomainService
    {
        public string GerarToken(Usuario usuario)
        {
            return jwtBearerSecurity.GenerateToken(usuario.Id.ToString(), "Usuario");
        }

        public void Inserir(Usuario usuario)
        {
            if (usuarioRepository.Any(usuario.Email))
                throw new ApplicationException("O email informado ja está cadastrado para outro usuairio.");

            usuarioRepository.Add(usuario);
        }

        public Usuario? Obter(string email, string senha)
        {
            return usuarioRepository.Find(email, senha);
        }
    }
}