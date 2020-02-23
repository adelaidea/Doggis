using Doggis.Domain.IRepository;
using Doggis.ExecutorsAbstraction.Abstraction;
using Doggis.ExecutorsAbstraction.ExecutorsTypes.Parameters.Cliente;
using Doggis.ExecutorsAbstraction.ExecutorsTypes.Results.Cliente;
using System.Threading.Tasks;

namespace Doggis.Executors.Cliente
{
    public class ObterClienteExecutor : IExecutor<ObterClienteParameter, ObterClienteResult>
    {
        private readonly IClienteRepository _clienteRepository;

        public ObterClienteExecutor(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        public async Task<ObterClienteResult> Execute(ObterClienteParameter parameter)
        {
            var cliente = await _clienteRepository.Get(parameter.Id);

            return new ObterClienteResult
            {
                CPF = cliente.CPF,
                Email = cliente.Email,
                Endereco = cliente.Endereco,
                Nome = cliente.Nome,
                RG = cliente.RG
            };
        }
    }
}
