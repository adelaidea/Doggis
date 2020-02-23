using Doggis.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Doggis.DataAccess.Config
{
    public class AlergiaPetConfig : IEntityTypeConfiguration<AlergiaPet>, IEntityConfig
    {
        public void Configure(EntityTypeBuilder<AlergiaPet> builder)
        {
            builder.ToTable("AlergiaPet");

            builder.HasKey(x => new { x.IdAlergia, x.IdPet });

            builder.Property(x => x.IdPet).IsRequired();
            builder.Property(x => x.IdAlergia).IsRequired();

            builder.HasOne(x => x.Pet)
                    .WithMany(x => x.Alergias)
                    .HasForeignKey(x => x.IdPet);

            builder.HasOne(x => x.Alergia)
                    .WithMany()
                    .HasForeignKey(x => x.IdAlergia);
        }
    }
}
