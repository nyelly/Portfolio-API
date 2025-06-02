using Microsoft.AspNetCore.Mvc;
using BackendPortfolio.Services;

namespace BackendPortfolio.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProjetosController : ControllerBase
    {
        private readonly ProjetosService _service;

        public ProjetosController(ProjetosService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var projetos = _service.GetTodos();
            return Ok(projetos);
        }
    }
}