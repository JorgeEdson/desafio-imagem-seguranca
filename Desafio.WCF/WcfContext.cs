using System.Data.Entity;
using System.Linq;

namespace Desafio.WCF
{
    public partial class WcfContext : DbContext
    {
        #region DbSets
        public virtual DbSet<Dispositivo> Dispositivos { get; set; }
        public virtual DbSet<Evento> Eventos { get; set; }
        #endregion

        public WcfContext(): base("name=WcfContext")
        {
        }

        #region Metodos Publicos
        public Dispositivo ObterDispositivoPorEndereco(int endereco)
        {
            return Dispositivos.FirstOrDefault(d => d.Endereco == endereco);
        }
        #endregion

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
