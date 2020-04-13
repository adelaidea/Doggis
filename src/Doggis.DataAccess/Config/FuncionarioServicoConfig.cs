using Doggis.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Doggis.DataAccess.Config
{
    public class FuncionarioServicoConfig : IEntityTypeConfiguration<FuncionarioServico>, IEntityConfig
    {
        public void Configure(EntityTypeBuilder<FuncionarioServico> builder)
        {
            builder.ToTable("FuncionarioServico");

            builder.HasKey(x => new { x.FuncionarioId, x.ServicoId });

            builder.Property(x => x.FuncionarioId).IsRequired();
            builder.Property(x => x.ServicoId).IsRequired();
        }
    }
}
