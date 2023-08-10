using Desafio.Core.Dominio.Entidades;
using Desafio.Database.Mapeamento.Base;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Desafio.Database.Mapeamento
{
    public class EventoMap : BaseEntidadeMap<Evento>
    {
        public EventoMap() : base("Eventos")
        {
        }

        public override void Configure(EntityTypeBuilder<Evento> builder)
        {
            base.Configure(builder);

            builder.Property(x => x.TipoEvento).HasColumnName("TipoEvento").IsRequired();
            builder.Property(x => x.DispositivoId).HasColumnName("DispositivoId").IsRequired();
            builder.HasOne(x => x.Dispositivo).WithMany(x => x.Eventos).HasForeignKey(x => x.DispositivoId);
        }
    } 
}
