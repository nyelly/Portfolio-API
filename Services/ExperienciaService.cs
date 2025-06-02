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

        public List<Experiencia> GetTodos()
        {
            return _context.Experiencias.ToList();
        }
    }
}