using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ComoFazerCrud.Models
{
    [Table("Login")]
    public class Login
    {
        [Display(Name = "E-mail")]
        [Column("E-mail")]
        public String Id { get; set; }

        [Display(Name = "Senha")]
        [Column("Senha")]
        public string? Senha { get; set; }

        [Display(Name = "Nome")]
        [Column("Nome")]
        public string? Nome { get; set; }

        [Display(Name = "Cliente")]
        [Column("Cliente")]
        public bool Cliente { get; set; }

    }
}
