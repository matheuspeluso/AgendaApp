using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AgendaApp.ApiUsuarios.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuariosController : ControllerBase
    {
        [HttpPost("autenticar")]
        public IActionResult Autenticar()
        {
            return Ok(new {mesagem="Login realizado com sucesso."});
        }

        [HttpPost("criar")]
        public IActionResult Criar()
        {
            return Ok();
        }
    }
}
