namespace BackendPortfolio.Models
{
    public class Projeto
    {
        public int ProjetoId { get; set; }
        public int UsuarioId { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string LinkRepositorio { get; set; }
        public string LinkDeploy { get; set; }
    }
}