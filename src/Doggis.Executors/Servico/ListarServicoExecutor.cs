using AutoMapper;
using Doggis.Domain.IRepository;
using Doggis.ExecutorsAbstraction.Abstraction;
using Doggis.ExecutorsAbstraction.ExecutorsTypes.Results.Servico;
using Doggis.ExecutorsAbstraction.Model.Servico;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Doggis.Executors.Servico
{
    public class ListarServicoExecutor : IExecutor<ListarServicoResult>
    {
        private readonly IMapper _mapper;
        private readonly IServicoRepository _servicoRepository;

        public ListarServicoExecutor(IMapper mapper, IServicoRepository servicoRepository)
        {
            _mapper = mapper;
            _servicoRepository = servicoRepository;
        }

        public async Task<ListarServicoResult> Execute()
        {
            var servicos = await _servicoRepository.GetAll();

            return new ListarServicoResult { Servicos = _mapper.Map<IEnumerable<ServicoModel>>(servicos) };
        }
    }
}
