using System.Collections.Generic;

namespace Doggis.ExecutorsAbstraction.ExecutorsTypes.Results.Funcionario
{
    public class ObterHorariosProfissionalResult : ResultBase
    {
        public IEnumerable<string> Horarios { get; set; }
    }
}