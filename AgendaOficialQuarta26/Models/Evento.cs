using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AgendaOficialQuarta26.Models
{
    [Table("Evento")]
    public class Evento
    {
        [Column("Id")]
        [Display(Name = "Id")]
        public int Id { get; set; }

        [Column("Tipo")]
        [Display(Name ="Tipo")]
        public string Tipo { get; set; }

        [Column("Nome")]
        [Display(Name = "Nome")]
        public string Nome { get; set; }

        [Column("Descrição")]
        [Display(Name = "Descrição")]
        public string Descrição { get; set; }
    }
}
