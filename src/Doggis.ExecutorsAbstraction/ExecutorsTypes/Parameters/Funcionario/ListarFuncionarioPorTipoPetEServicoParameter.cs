using System;

namespace Doggis.ExecutorsAbstraction.ExecutorsTypes.Parameters.Funcionario
{
    public class ListarFuncionarioPorTipoPetEServicoParameter : ParameterBase
    {
        public int TipoPetId { get; set; }

        public Guid ServicoId { get; set; }
    }
}
