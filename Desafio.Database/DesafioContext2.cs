using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using Desafio.Database.Dominio;

namespace Desafio.Database
{
    public partial class DesafioContext2 : DbContext
    {
        public DesafioContext2()
            : base("name=DesafioContext")
        {
        }

        public virtual DbSet<Dispositivo> Dispositivos { get; set; }
        public virtual DbSet<Evento> Eventos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Dispositivo>()
               .HasMany(e => e.Eventos)
               .WithRequired(e => e.Dispositivo)
               .HasForeignKey(e => e.DispositivoId);
        }
    }
}
