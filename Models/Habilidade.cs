namespace BackendPortfolio.Models
{
    public class Habilidade
    {
        public int HabilidadeId { get; set; }
        public int UsuarioId { get; set; }
        public string Nome { get; set; }
        public string Nivel { get; set; }
    }
}