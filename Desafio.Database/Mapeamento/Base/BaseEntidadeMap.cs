using Desafio.Core.Dominio.Base;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Desafio.Database.Mapeamento.Base
{
    public class BaseEntidadeMap<T> : IEntityTypeConfiguration<T> where T : BaseEntidade
    {
        private readonly string _nomeTabela;

        public BaseEntidadeMap(string nomeTabela = "")
        {
                _nomeTabela = nomeTabela;
        }
        public virtual void Configure(EntityTypeBuilder<T> builder)
        {
            if (!string.IsNullOrEmpty(_nomeTabela))
            {
                builder.ToTable(_nomeTabela);
            }
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).HasColumnName("Id").ValueGeneratedOnAdd();            
        }
    }
}
