using Microsoft.AspNetCore.Mvc;
using BackendPortfolio.Services;

namespace BackendPortfolio.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ExperienciaController : ControllerBase
    {
        private readonly ExperienciaService _service;

        public ExperienciaController(ExperienciaService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var experiencias = _service.GetTodos();
            return Ok(experiencias);
        }
    }
}