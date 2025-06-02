namespace BackendPortfolio.Models
{
    public class Formacao
    {
        public int FormacaoId { get; set; }
        public int UsuarioId { get; set; }
        public string Curso { get; set; }
        public string Instituicao { get; set; }
        public int AnoConclusao { get; set; }
    }
}