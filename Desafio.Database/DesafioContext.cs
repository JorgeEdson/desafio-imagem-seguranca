using Microsoft.EntityFrameworkCore;
using Desafio.Core.Dominio.Entidades;

namespace Desafio.Database
{
    internal class DesafioContext : DbContext
    {
        public virtual DbSet<Dispositivo> Dispositivos { get; set; }
        public virtual DbSet<Evento> Eventos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {            
            optionsBuilder.UseSqlServer("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=DesafioImageSegurancaDb;Data Source=ASUSDEV");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);
            base.OnModelCreating(modelBuilder);
        }
    }
}
