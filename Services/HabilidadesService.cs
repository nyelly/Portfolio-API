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

        public List<Habilidade> GetTodos()
        {
            return _context.Habilidades.ToList();
        }
    }
}