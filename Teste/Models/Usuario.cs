using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Moveis_Carrara.Models
{
    [Table("usuarios")]
    public class Usuario
    {
        [Key]
        [Column("pessoa_codigo")]
        public int PessoaCodigo { get; set; }

        [Column("usuario_nome")]
        [StringLength(50)]
        public string UsuarioNome { get; set; }

        [Column("usuario_senha")]
        [StringLength(50)]
        public string UsuarioSenha { get; set; }

        [ForeignKey("PessoaCodigo")]
        public virtual Pessoa Pessoa { get; set; }
    }
}
