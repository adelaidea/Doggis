using AutoMapper;
using Doggis.Domain.IRepository;
using Doggis.ExecutorsAbstraction.Abstraction;
using Doggis.ExecutorsAbstraction.ExecutorsTypes.Results.Cliente;
using Doggis.ExecutorsAbstraction.Model.Cliente;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Doggis.Executors.Cliente
{
    public class ListarClienteExecutor : IExecutor<ListarClienteResult>
    {
        private readonly IMapper _mapper;
        private readonly IClienteRepository _clienteRepository;

        public ListarClienteExecutor(IMapper mapper, IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
            _mapper = mapper;
        }

        public async Task<ListarClienteResult> Execute()
        {
            var clientes = await _clienteRepository.GetAll();

            return new ListarClienteResult { Clientes = _mapper.Map<IEnumerable<ClienteModel>>(clientes) };
        }
    }
}
