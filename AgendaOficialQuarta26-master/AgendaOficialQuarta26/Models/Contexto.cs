using Microsoft.EntityFrameworkCore;

namespace AgendaOficialQuarta26.Models
{
    public class Contexto : DbContext
    {
        public Contexto( DbContextOptions<Contexto> options) : base(options) 
        {
        
        }

        public DbSet<Agenda> Agenda { get; set; }
        public DbSet<Usuario>  Usuario { get; set; }
        public DbSet<Evento> Evento { get; set; }
    }
}
