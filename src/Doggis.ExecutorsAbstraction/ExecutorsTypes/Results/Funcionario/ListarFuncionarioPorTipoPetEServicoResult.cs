using Doggis.ExecutorsAbstraction.Model.Funcionario;
using System.Collections.Generic;

namespace Doggis.ExecutorsAbstraction.ExecutorsTypes.Results.Funcionario
{
    public class ListarFuncionarioPorTipoPetEServicoResult : ResultBase
    {
        public IEnumerable<FuncionarioModel> Funcionarios { get; set; }
    }
}