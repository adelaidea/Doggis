using Doggis.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Doggis.DataAccess.Config
{
    public class DisponibilidadeFuncionarioConfig : IEntityTypeConfiguration<DisponibilidadeFuncionario>, IEntityConfig
    {
        public void Configure(EntityTypeBuilder<DisponibilidadeFuncionario> builder)
        {
            builder.ToTable("DisponibilidadeFuncionario");

            builder.HasKey(x => new { x.FuncionarioId, x.DiaSemana, x.HorarioFim, x.HorarioInicio });

            builder.Property(x => x.FuncionarioId);
            builder.Property(x => x.DiaSemana);
            builder.Property(x => x.HorarioFim);
            builder.Property(x => x.HorarioInicio);
        }
    }
}