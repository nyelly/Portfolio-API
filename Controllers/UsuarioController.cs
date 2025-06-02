using Microsoft.AspNetCore.Mvc;
using BackendPortfolio.Services;

namespace BackendPortfolio.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsuarioController : ControllerBase
    {
        private readonly UsuarioService _service;

        public UsuarioController(UsuarioService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var usuarios = _service.GetTodos();
            return Ok(usuarios);
        }
    }
}