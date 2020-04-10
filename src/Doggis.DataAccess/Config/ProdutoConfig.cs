using Doggis.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Doggis.DataAccess.Config
{
    public class ProdutoConfig : IEntityTypeConfiguration<Produto>, IEntityConfig
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.HasKey(x => x.Codigo);

            builder.Property(x => x.Codigo);
            builder.Property(x => x.Especificacoes);
            builder.Property(x => x.Nome);
            builder.Property(x => x.ParaVenda);
            builder.Property(x => x.Preco);
            builder.Property(x => x.Quantidade);
            builder.Property(x => x.FabricanteId);
        }
    }
}
