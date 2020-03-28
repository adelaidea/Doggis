using Doggis.ExecutorsAbstraction.Model.Servico;
using System.Collections.Generic;

namespace Doggis.ExecutorsAbstraction.ExecutorsTypes.Results.Servico
{
    public class ObterServicosAgendadosResult : ResultBase
    {
        public IEnumerable<AgendaServicoListaModel> ServicosAgendados { get; set; }
    }
}
