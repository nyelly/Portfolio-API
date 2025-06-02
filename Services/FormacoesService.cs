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

        public List<Formacao> GetTodos()
        {
            return _context.Formacoes.ToList();
        }
    }
}
