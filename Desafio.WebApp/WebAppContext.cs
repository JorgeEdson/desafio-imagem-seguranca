using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Desafio.WebApp
{
    public partial class WebAppContext : DbContext
    {
        public WebAppContext(): base("name=WebAppContext")
        {
        }

        public virtual DbSet<Dispositivo> Dispositivos { get; set; }
        public virtual DbSet<Evento> Eventos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Dispositivo>()
                .HasMany(e => e.Eventos)
                .WithRequired(e => e.Dispositivo)
                .HasForeignKey(e => e.DispositivoId)
                .WillCascadeOnDelete(false);

            base.OnModelCreating(modelBuilder);
        }
    }
}
