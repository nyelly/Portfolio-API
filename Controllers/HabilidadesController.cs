using Microsoft.AspNetCore.Mvc;
using BackendPortfolio.Services;

namespace BackendPortfolio.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HabilidadesController : ControllerBase
    {
        private readonly HabilidadesService _service;

        public HabilidadesController(HabilidadesService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var habilidades = _service.GetTodos();
            return Ok(habilidades);
        }
    }
}