using Microsoft.AspNetCore.Mvc;
using BackendPortfolio.Services;
using BackendPortfolio.Models;

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
        public async Task<ActionResult<List<Experiencia>>> GetAll() => await _service.GetAllAsync();

        [HttpGet("{id}")]
        public async Task<ActionResult<Experiencia>> GetById(int id)
        {
            var experiencia = await _service.GetByIdAsync(id);
            if (experiencia == null) return NotFound();
            return experiencia;
        }

        [HttpPost]
        public async Task<ActionResult<Experiencia>> Create(Experiencia experiencia) => await _service.CreateAsync(experiencia);

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, Experiencia experiencia)
        {
            var atualizado = await _service.UpdateAsync(id, experiencia);
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