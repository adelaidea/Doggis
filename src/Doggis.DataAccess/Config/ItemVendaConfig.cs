using Doggis.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Doggis.DataAccess.Config
{
    public class ItemVendaConfig : IEntityTypeConfiguration<ItemVenda>, IEntityConfig
    {
        public void Configure(EntityTypeBuilder<ItemVenda> builder)
        {
            builder.HasKey(x => new { x.VendaId, x.CodigoProduto });

            builder.Property(x => x.CodigoProduto);
            builder.Property(x => x.Quantidade);
            builder.Property(x => x.ValorItem);
            builder.Property(x => x.VendaId);

            builder.HasOne(x => x.Produto)
                    .WithMany()
                    .HasForeignKey(x => x.CodigoProduto);
        }
    }
}
