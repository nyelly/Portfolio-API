using Microsoft.EntityFrameworkCore;
using BackendPortfolio.Models;

namespace BackendPortfolio.Database
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Formacao> Formacoes { get; set; }
        public DbSet<Experiencia> Experiencias { get; set; }
        public DbSet<Projeto> Projetos { get; set; }
        public DbSet<Habilidade> Habilidades { get; set; }
    }
}