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

        public List<Projeto> GetTodos()
        {
            return _context.Projetos.ToList();
        }
    }
}
