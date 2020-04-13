using Doggis.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Doggis.DataAccess.Config
{
    public class PetConfig : IEntityTypeConfiguration<Pet>, IEntityConfig
    {
        public void Configure(EntityTypeBuilder<Pet> builder)
        {
            builder.ToTable("Pet");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).IsRequired();
            builder.Property(x => x.ClienteId).IsRequired();
            builder.Property(x => x.RacaId).IsRequired();
            builder.Property(x => x.Nome).IsRequired();
            builder.Property(x => x.Observacoes);
            builder.Property(x => x.PermiteDivulgacao).IsRequired();
            builder.Property(x => x.Porte).IsRequired();

            builder.HasOne(x => x.Raca)
                    .WithMany()
                    .HasForeignKey(x => x.RacaId);
        }
    }
}
