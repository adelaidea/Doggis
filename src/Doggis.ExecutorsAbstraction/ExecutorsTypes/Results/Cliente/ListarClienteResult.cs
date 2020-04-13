using Doggis.ExecutorsAbstraction.Model.Cliente;
using System.Collections.Generic;

namespace Doggis.ExecutorsAbstraction.ExecutorsTypes.Results.Cliente
{
    public class ListarClienteResult : ResultBase
    {
        public IEnumerable<ClienteModel> Clientes { get; set; }
    }
}
