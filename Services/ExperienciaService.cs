using BackendPortfolio.Database;
using BackendPortfolio.Models;
using Microsoft.EntityFrameworkCore;

namespace BackendPortfolio.Services
{
    public class ExperienciaService
    {
        private readonly AppDbContext _context;

        public ExperienciaService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<Experiencia>> GetAllAsync()
        {
            return await _context.Experiencias.ToListAsync();
        }

        public async Task<Experiencia?> GetByIdAsync(int id)
        {
            return await _context.Experiencias.FindAsync(id);
        }

        public async Task<Experiencia> CreateAsync(Experiencia experiencia)
        {
            _context.Experiencias.Add(experiencia);
            await _context.SaveChangesAsync();
            return experiencia;
        }

        public async Task<bool> UpdateAsync(int id, Experiencia experiencia)
        {
            var existente = await _context.Experiencias.FindAsync(id);
            if (existente == null) return false;

            existente.Empresa = experiencia.Empresa;
            existente.Cargo = experiencia.Cargo;
            existente.Descricao = experiencia.Descricao;
            existente.Inicio = experiencia.Inicio;
            existente.Fim = experiencia.Fim;
            existente.UsuarioId = experiencia.UsuarioId;

            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var experiencia = await _context.Experiencias.FindAsync(id);
            if (experiencia == null) return false;

            _context.Experiencias.Remove(experiencia);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}