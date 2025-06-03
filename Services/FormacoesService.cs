using BackendPortfolio.Database;
using BackendPortfolio.Models;
using Microsoft.EntityFrameworkCore;

namespace BackendPortfolio.Services
{
    public class FormacoesService
    {
        private readonly AppDbContext _context;

        public FormacoesService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<Formacao>> GetAllAsync()
        {
            return await _context.Formacoes.ToListAsync();
        }

        public async Task<Formacao?> GetByIdAsync(int id)
        {
            return await _context.Formacoes.FindAsync(id);
        }

        public async Task<Formacao> CreateAsync(Formacao formacao)
        {
            _context.Formacoes.Add(formacao);
            await _context.SaveChangesAsync();
            return formacao;
        }

        public async Task<bool> UpdateAsync(int id, Formacao formacao)
        {
            var existente = await _context.Formacoes.FindAsync(id);
            if (existente == null) return false;

            existente.Curso = formacao.Curso;
            existente.Instituicao = formacao.Instituicao;
            existente.AnoConclusao = formacao.AnoConclusao;
            existente.UsuarioId = formacao.UsuarioId;

            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var formacao = await _context.Formacoes.FindAsync(id);
            if (formacao == null) return false;

            _context.Formacoes.Remove(formacao);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}