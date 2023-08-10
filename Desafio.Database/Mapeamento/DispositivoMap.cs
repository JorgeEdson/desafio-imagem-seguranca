using Desafio.Core.Dominio.Entidades;
using Desafio.Database.Mapeamento.Base;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Desafio.Database.Mapeamento
{
    public class DispositivoMap : BaseEntidadeMap<Dispositivo>
    {
        public DispositivoMap():base("Dispositivos")
        {                
        }

        public override void Configure(EntityTypeBuilder<Dispositivo> builder)
        {
            base.Configure(builder);

            builder.Property(x => x.Nome).HasColumnName("Nome").HasMaxLength(100).IsRequired();
            builder.Property(x => x.Endereco).HasColumnName("Endereco").IsRequired();            
        }
    }
}
