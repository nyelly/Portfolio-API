using Microsoft.AspNetCore.Mvc;
using BackendPortfolio.Services;
using BackendPortfolio.Models;

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
        public async Task<ActionResult<List<Projeto>>> GetAll() => await _service.GetAllAsync();

        [HttpGet("{id}")]
        public async Task<ActionResult<Projeto>> GetById(int id)
        {
            var projeto = await _service.GetByIdAsync(id);
            if (projeto == null) return NotFound();
            return projeto;
        }

        [HttpPost]
        public async Task<ActionResult<Projeto>> Create(Projeto projeto) => await _service.CreateAsync(projeto);

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, Projeto projeto)
        {
            var atualizado = await _service.UpdateAsync(id, projeto);
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