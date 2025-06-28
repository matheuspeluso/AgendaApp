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
    public class UsuarioAppServices(IUsuarioDomainService usuarioDomainService) : IUsuarioAppService
    {
        public AutenticarUsuarioResponse Autenticar(AutenticarUsuarioRequest request)
        {
            throw new NotImplementedException();
        }

        public CriarUsuarioResponse Criar(CriarUsuarioRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
