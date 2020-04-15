using System;

namespace Doggis.ExecutorsAbstraction.ExecutorsTypes.Parameters.Funcionario
{
    public class ObterHorariosProfissionalParameter : ParameterBase
    {
        public Guid FuncionarioId { get; set; }

        public DateTime Dia { get; set; }

        public Guid ServicoId { get; set; }
    }
}
