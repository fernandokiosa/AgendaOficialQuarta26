using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AgendaOficialQuarta26.Models
{
    [Table("Agenda")]
    public class Usuario
    {
        [Column]
        [Key] 
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Nome { get; set; }

        [Column("Email")]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Column("Senha")]
        [Display(Name = "Senha")]
        public string Senha { get; set; }

        [Column("Data de nascimento")]
        [Display(Name = "Data de nascimento")]
        public DateTime Data_nascimento { get; set; }

        [Column("Sexo")]
        [Display(Name = "Sexo")]
        public string Sexo { get; set; }

        public List<Evento> Eventos{ get; set; }

    }
}
