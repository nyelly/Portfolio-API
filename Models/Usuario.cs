using System.ComponentModel.DataAnnotations.Schema;

namespace BackendPortfolio.Models
{
    [Table("usuario")]
    public class Usuario
    {
        public int UsuarioId { get; set; }
        public string Nome { get; set; }
        public string Bio { get; set; }
        public string Email { get; set; }
        public string GitHub { get; set; }
        public string LinkedIn { get; set; }
    }
}