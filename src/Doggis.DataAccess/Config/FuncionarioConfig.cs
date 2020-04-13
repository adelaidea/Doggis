using Doggis.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Doggis.DataAccess.Config
{
    public class FuncionarioConfig : IEntityTypeConfiguration<Funcionario>, IEntityConfig
    {
        public void Configure(EntityTypeBuilder<Funcionario> builder)
        {
            builder.ToTable("Funcionario");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).IsRequired();
            builder.Property(x => x.Nome).IsRequired();
            builder.Property(x => x.Registro);
            builder.Property(x => x.RG).IsRequired();
            builder.Property(x => x.CPF).IsRequired();

            builder.HasMany(x => x.Servicos)
                    .WithOne()
                    .HasForeignKey(x => x.FuncionarioId);


            builder.HasMany(x => x.TiposPet)
                    .WithOne()
                    .HasForeignKey(x => x.FuncionarioId);
        }
    }
}
