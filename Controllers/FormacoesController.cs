using BackendPortfolio.Models;
using BackendPortfolio.Services;
using Microsoft.AspNetCore.Mvc;

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
        public async Task<ActionResult<List<Formacao>>> GetAll() => await _service.GetAllAsync();

        [HttpGet("{id}")]
        public async Task<ActionResult<Formacao>> GetById(int id)
        {
            var formacao = await _service.GetByIdAsync(id);
            if (formacao == null) return NotFound();
            return formacao;
        }

        [HttpPost]
        public async Task<ActionResult<Formacao>> Create(Formacao formacao) => await _service.CreateAsync(formacao);

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, Formacao formacao)
        {
            var atualizado = await _service.UpdateAsync(id, formacao);
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