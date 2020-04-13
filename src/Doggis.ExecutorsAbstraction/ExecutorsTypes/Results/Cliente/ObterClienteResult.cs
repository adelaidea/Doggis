using Doggis.ExecutorsAbstraction.Model.Cliente;

namespace Doggis.ExecutorsAbstraction.ExecutorsTypes.Results.Cliente
{
    public class ObterClienteResult : ResultBase
    {
        public ClienteModel Cliente { get; set; }
    }
}
