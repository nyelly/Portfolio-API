using BackendPortfolio.Database;
using BackendPortfolio.Models;
using Microsoft.EntityFrameworkCore;

namespace BackendPortfolio.Services
{
    public class HabilidadesService
    {
        private readonly AppDbContext _context;

        public HabilidadesService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<Habilidade>> GetAllAsync()
        {
            return await _context.Habilidades.ToListAsync();
        }

        public async Task<Habilidade?> GetByIdAsync(int id)
        {
            return await _context.Habilidades.FindAsync(id);
        }

        public async Task<Habilidade> CreateAsync(Habilidade habilidade)
        {
            _context.Habilidades.Add(habilidade);
            await _context.SaveChangesAsync();
            return habilidade;
        }

        public async Task<bool> UpdateAsync(int id, Habilidade habilidade)
        {
            var existente = await _context.Habilidades.FindAsync(id);
            if (existente == null) return false;

            existente.Nome = habilidade.Nome;
            existente.Nivel = habilidade.Nivel;
            existente.UsuarioId = habilidade.UsuarioId;

            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var habilidade = await _context.Habilidades.FindAsync(id);
            if (habilidade == null) return false;

            _context.Habilidades.Remove(habilidade);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}