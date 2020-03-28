using Doggis.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Doggis.DataAccess.Config
{
    public class ServicoConfig : IEntityTypeConfiguration<Servico>, IEntityConfig
    {
        public void Configure(EntityTypeBuilder<Servico> builder)
        {
            builder.ToTable("Servico");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id);
            builder.Property(x => x.Ativo);
            builder.Property(x => x.Nome);
            builder.Property(x => x.MinDuracao);
            builder.Property(x => x.Preco);
            builder.Property(x => x.PontosRealizavao);
        }
    }
}
