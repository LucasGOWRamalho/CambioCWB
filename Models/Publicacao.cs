using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata;

namespace ComoFazerCrud.Models
{
    [Table("Publicacao")]
    public class Publicacao
    {
        [Display(Name = "Id")]
        [Column("Id")]
        public int Id { get; set; }

        [Display(Name = "Nome")]
        [Column("Nome")]
        public string Name { get; set; }

        [Display(Name = "Valor")]
        [Column("Valor")]
        public float Valor { get; set; }

        [Display(Name = "Quantidade")]
        [Column("Quantidade")]
        public int Quantidade { get; set; }

        [Display(Name = "Imagem")]
        [Column("Imagem")]
        public byte[]? Imagem { get; set; }
    }
}