using AutoMapper;
using Doggis.Domain.IRepository;
using Doggis.ExecutorsAbstraction.Abstraction;
using Doggis.ExecutorsAbstraction.ExecutorsTypes.Parameters.Cliente;
using Doggis.ExecutorsAbstraction.ExecutorsTypes.Results.Cliente;
using Doggis.ExecutorsAbstraction.Model.Cliente;
using System.Threading.Tasks;

namespace Doggis.Executors.Cliente
{
    public class ObterClienteExecutor : IExecutor<ObterClienteParameter, ObterClienteResult>
    {
        private readonly IMapper _mapper;
        private readonly IClienteRepository _clienteRepository;

        public ObterClienteExecutor(IClienteRepository clienteRepository, IMapper mapper)
        {
            _mapper = mapper;
            _clienteRepository = clienteRepository;
        }

        public async Task<ObterClienteResult> Execute(ObterClienteParameter parameter)
        {
            var cliente = await _clienteRepository.Get(parameter.Id);

            return new ObterClienteResult
            {
                Cliente = _mapper.Map<ClienteModel>(cliente)
            };
        }
    }
}
