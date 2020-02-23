using Doggis.Domain.IRepository;
using Doggis.ExecutorsAbstraction.Abstraction;
using Doggis.ExecutorsAbstraction.ExecutorsTypes.Parameters.Cliente;
using Doggis.ExecutorsAbstraction.ExecutorsTypes.Results.Cliente;
using System.Threading.Tasks;

namespace Doggis.Executors.Cliente
{
    public class IncluirClienteExecutor : IExecutor<IncluirClienteParameter, IncluirClienteResult>
    {
        private readonly IClienteRepository _clienteRepository;

        public IncluirClienteExecutor(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        public async Task<IncluirClienteResult> Execute(IncluirClienteParameter parameter)
        {
            var cliente = new Domain.Entities.Cliente(parameter.Nome, parameter.RG, parameter.CPF, parameter.Email, parameter.Endereco);

            await _clienteRepository.Add(cliente);

            return new IncluirClienteResult();
        }
    }
}