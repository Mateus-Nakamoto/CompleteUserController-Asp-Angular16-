using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ControleDeUsuario.Models
{
    public class ControleUsuario
    {
        [Key]
        public int pessoaID { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string pessoaNome { get; set; } = "";

        [Column(TypeName = "nvarchar(100)")]
        public string pessoaEmail { get; set; } = "";

        [Column(TypeName = "nvarchar(100)")]
        public string pessoaTelefone { get; set; } = "";

        [Column(TypeName = "nvarchar(100)")]
        public string pessoaDataNascimento { get; set; } = "";
    }
}
