using Microsoft.AspNetCore.Mvc;
using BackendPortfolio.Services;
using BackendPortfolio.Models;

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
        public async Task<ActionResult<List<Habilidade>>> GetAll() => await _service.GetAllAsync();

        [HttpGet("{id}")]
        public async Task<ActionResult<Habilidade>> GetById(int id)
        {
            var habilidade = await _service.GetByIdAsync(id);
            if (habilidade == null) return NotFound();
            return habilidade;
        }

        [HttpPost]
        public async Task<ActionResult<Habilidade>> Create(Habilidade habilidade) => await _service.CreateAsync(habilidade);

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, Habilidade habilidade)
        {
            var atualizado = await _service.UpdateAsync(id, habilidade);
            if (!atualizado) return NotFound();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var deletado = await _service.DeleteAsync(id);
            if (!deletado) return NotFound();
            return NoContent();
        }
    }
}
