using Doggis.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Doggis.DataAccess.Config
{
    public class ClienteConfig : IEntityTypeConfiguration<Cliente>, IEntityConfig
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.ToTable("Cliente");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id);
            builder.Property(x => x.Nome).IsRequired();
            builder.Property(x => x.RG).IsRequired();
            builder.Property(x => x.CPF).IsRequired();
            builder.Property(x => x.Email).IsRequired();
            builder.Property(x => x.Endereco).IsRequired();
            builder.Property(x => x.PontosAcumulados);
        }
    }
}