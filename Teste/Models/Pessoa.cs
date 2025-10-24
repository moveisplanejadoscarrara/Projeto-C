using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Moveis_Carrara.Models
{
    [Table("pessoas")]
    public class Pessoa
    {
        [Key]
        [Column("codigo")]
        public int Codigo { get; set; }

        [Column("nome")]
        [StringLength(50)]
        public string Nome { get; set; }

        [Column("tipo_pessoa")]
        [StringLength(20)]
        public string TipoPessoa { get; set; }

        [Column("documento")]
        [StringLength(14)]
        public string Documento { get; set; }

        [Column("tipo_documento")]
        [StringLength(20)]
        public string TipoDocumento { get; set; }

        [Column("email")]
        [StringLength(100)]
        public string Email { get; set; }

        [Column("telefone")]
        [StringLength(20)]
        public string Telefone { get; set; }

        [Column("cep")]
        [StringLength(10)]
        public string Cep { get; set; }

        [Column("logradouro")]
        [StringLength(50)]
        public string Logradouro { get; set; }

        [Column("nr")]
        [StringLength(5)]
        public string Nr { get; set; }

        [Column("cidade")]
        [StringLength(100)]
        public string Cidade { get; set; }

        [Column("bairro")]
        [StringLength(100)]
        public string Bairro { get; set; }
    }
}
