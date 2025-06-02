using Microsoft.AspNetCore.Mvc;
using BackendPortfolio.Services;

namespace BackendPortfolio.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FormacoesController : ControllerBase
    {
        private readonly FormacoesService _service;

        public FormacoesController(FormacoesService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var formacoes = _service.GetTodos();
            return Ok(formacoes);
        }
    }
}