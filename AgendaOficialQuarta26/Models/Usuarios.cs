using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AgendaOficialQuarta26.Models
{
    [Table("Usuario")]
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

        [Column("Data_nascimento")]
        [Display(Name = "Data de nascimento")]
        public DateTime Data_nascimento { get; set; }

        [Column("Sexo")]
        [Display(Name = "Sexo")]
        public string Sexo { get; set; }

        public List<Usuario> Eventos{ get; set; }

    }
}
