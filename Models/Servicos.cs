using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ComoFazerCrud.Models
{
    [Table("Servicos")]
    public class Servicos
    {
        [Display(Name ="ID")]
        [Column("Id")]
        public int Id { get; set; }

        [Display(Name = "Ordem")]
        [Column("Ordem")]
        public string? Ordem { get; set; }

        [Display(Name = "Valor")]
        [Column("Valor")]
        public float Valor { get; set;}

        [Display(Name = "Data de entrega")]
        [Column("Data de entrega")]
        public DateTime DataDeEntrega { get; set; }

        [Display(Name = "Pago")]
        [Column("Pago")]
        public bool Pago { get; set; }

        [Display(Name = "Modelo")]
        [Column("Modelo")]
        public string? Modelo { get; set; }
        
      
    }
}

