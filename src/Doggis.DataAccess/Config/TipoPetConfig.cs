using Doggis.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Doggis.DataAccess.Config
{
    public class TipoPetConfig : IEntityTypeConfiguration<TipoPet>, IEntityConfig
    {
        public void Configure(EntityTypeBuilder<TipoPet> builder)
        {
            builder.ToTable("TipoPet");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).IsRequired();
            builder.Property(x => x.Nome).IsRequired();
        }
    }
}
