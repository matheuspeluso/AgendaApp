using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AgendaApp.Application.Models.Requests;
using AgendaApp.Application.Models.Responses;

namespace AgendaApp.Application.Interfacies
{
    public interface IUsuarioAppService
    {
        CriarUsuarioResponse Criar(CriarUsuarioRequest request);

        AutenticarUsuarioResponse Autenticar(AutenticarUsuarioRequest request);

    }
}
