using Doggis.ExecutorsAbstraction.Model.Fabricante;
using System.Collections.Generic;

namespace Doggis.ExecutorsAbstraction.ExecutorsTypes.Results.Fabricante
{
    public class ListarFabricanteResult : ResultBase
    {
        public IEnumerable<FabricanteModel> Fabricantes { get; set; }
    }
}