using LivrosAnimados.Identidade.API.Controllers.InputModels;
using Microsoft.AspNetCore.Mvc;

namespace LivrosAnimados.Identidade.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsuarioController : Controller
    {
        [HttpPost]
        public ActionResult CriarUsuario(UsuarioInputModel usuarioInputModel)
        {

        }
    }
}
