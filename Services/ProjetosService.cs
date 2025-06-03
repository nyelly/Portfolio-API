using BackendPortfolio.Database;
using BackendPortfolio.Models;
using Microsoft.EntityFrameworkCore;

namespace BackendPortfolio.Services
{
    public class ProjetosService
    {
        private readonly AppDbContext _context;

        public ProjetosService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<Projeto>> GetAllAsync()
        {
            return await _context.Projetos.ToListAsync();
        }

        public async Task<Projeto?> GetByIdAsync(int id)
        {
            return await _context.Projetos.FindAsync(id);
        }

        public async Task<Projeto> CreateAsync(Projeto projeto)
        {
            _context.Projetos.Add(projeto);
            await _context.SaveChangesAsync();
            return projeto;
        }

        public async Task<bool> UpdateAsync(int id, Projeto projeto)
        {
            var existente = await _context.Projetos.FindAsync(id);
            if (existente == null) return false;

            existente.Nome = projeto.Nome;
            existente.Descricao = projeto.Descricao;
            existente.LinkRepositorio = projeto.LinkRepositorio;
            existente.LinkDeploy = projeto.LinkDeploy;
            existente.UsuarioId = projeto.UsuarioId;

            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var projeto = await _context.Projetos.FindAsync(id);
            if (projeto == null) return false;

            _context.Projetos.Remove(projeto);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}