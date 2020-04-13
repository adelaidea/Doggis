using System;

namespace Doggis.Domain.Entities
{
    public class DisponibilidadeFuncionario
    {
        public Guid FuncionarioId { get; set; }

        public short DiaSemana { get; set; }

        public TimeSpan HorarioInicio { get; set; }

        public TimeSpan HorarioFim { get; set; }
    }
}
