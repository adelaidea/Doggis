using Doggis.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Doggis.DataAccess.Config
{
    public class AgendaServicoConfig : IEntityTypeConfiguration<AgendaServico>, IEntityConfig
    {
        public void Configure(EntityTypeBuilder<AgendaServico> builder)
        {
            builder.ToTable("AgendaServico");

            builder.HasKey(x => new { x.ClienteId, x.FuncionarioId, x.DataRealizacao, x.ServicoId, x.PetId });

            builder.Property(x => x.PetId);
            builder.Property(x => x.Pontos);
            builder.Property(x => x.ServicoId);
            builder.Property(x => x.ValorPago);
            builder.Property(x => x.Cancelado);
            builder.Property(x => x.ClienteId);
            builder.Property(x => x.CodigoPromocao);
            builder.Property(x => x.DataRealizacao);
            builder.Property(x => x.FuncionarioId);

            builder.HasOne(x => x.Funcionario)
                    .WithMany()
                    .HasForeignKey(x => x.FuncionarioId);

            builder.HasOne(x => x.Cliente)
                    .WithMany()
                    .HasForeignKey(x => x.ClienteId);

            builder.HasOne(x => x.Pet)
                    .WithMany()
                    .HasForeignKey(x => x.PetId);

            builder.HasOne(x => x.Servico)
                    .WithMany()
                    .HasForeignKey(x => x.ServicoId);
        }
    }
}