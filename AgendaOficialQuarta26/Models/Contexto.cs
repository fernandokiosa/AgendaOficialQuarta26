using Microsoft.EntityFrameworkCore;

namespace AgendaOficialQuarta26.Models
{
    public class Contexto : DbContext
    {
        public Contexto( DbContextOptions<Contexto> options) : base(options) 
        {
        
        }

        public DbSet<Agendas> Agenda { get; set; }
        public DbSet<Agendas>  Usuario { get; set; }
        public DbSet<Evento> Evento { get; set; }
    }
}
