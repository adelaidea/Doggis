using Doggis.ExecutorsAbstraction.Model.Servico;
using System.Collections.Generic;

namespace Doggis.ExecutorsAbstraction.ExecutorsTypes.Results.Servico
{
    public class ListarServicoResult : ResultBase
    {
        public IEnumerable<ServicoModel> Servicos { get; set; }
    }
}