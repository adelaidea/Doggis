using Doggis.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Doggis.DataAccess.Config
{
    public class VendaConfig : IEntityTypeConfiguration<Venda>, IEntityConfig
    {
        public void Configure(EntityTypeBuilder<Venda> builder)
        {
            builder.ToTable("Venda");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id);
            builder.Property(x => x.FuncionarioVendaId);

            builder.HasOne(x => x.FuncionarioVenda)
                    .WithMany()
                    .HasForeignKey(x => x.FuncionarioVendaId);

            builder.HasMany(x => x.Itens)
                    .WithOne()
                    .HasForeignKey(x => x.VendaId);
        }
    }
}
