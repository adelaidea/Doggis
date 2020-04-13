using Doggis.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Doggis.DataAccess.Config
{
    public class FuncionarioTipoPetConfig : IEntityTypeConfiguration<FuncionarioTipoPet>, IEntityConfig
    {
        public void Configure(EntityTypeBuilder<FuncionarioTipoPet> builder)
        {
            builder.ToTable("FuncionarioTipoPet");

            builder.HasKey(x => new { x.FuncionarioId, x.TipoPetId });

            builder.Property(x => x.FuncionarioId).IsRequired();
            builder.Property(x => x.TipoPetId).IsRequired();
        }
    }
}
