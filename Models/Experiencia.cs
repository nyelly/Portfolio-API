namespace BackendPortfolio.Models
{
    public class Experiencia
    {
        public int ExperienciaId { get; set; }
        public int UsuarioId { get; set; }
        public string Cargo { get; set; }
        public string Empresa { get; set; }
        public DateTime Inicio { get; set; }
        public DateTime Fim { get; set; }
        public string Descricao { get; set; }
    }
}