using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AgendaOficialQuarta26.Models
{
    [Table("Agenda")]
    public class Agenda
    {
        [Column]
        [Key] 
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Nome { get; set; }

        public List<Agenda> Agendas{ get; set; }

    }
}
