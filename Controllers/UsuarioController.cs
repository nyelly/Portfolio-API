using BackendPortfolio.Models;
using BackendPortfolio.Services;
using Microsoft.AspNetCore.Mvc;

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
        public async Task<ActionResult<List<Usuario>>> GetAll()
        {
            return await _service.GetAllAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Usuario>> GetById(int id)
        {
            var usuario = await _service.GetByIdAsync(id);
            if (usuario == null)
                return NotFound();
            return usuario;
        }

        [HttpPost]
        public async Task<ActionResult<Usuario>> Create(Usuario usuario)
        {
            return await _service.CreateAsync(usuario);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, Usuario usuario)
        {
            var atualizado = await _service.UpdateAsync(id, usuario);
            if (!atualizado)
                return NotFound();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var deletado = await _service.DeleteAsync(id);
            if (!deletado)
                return NotFound();
            return NoContent();
        }
    }
}