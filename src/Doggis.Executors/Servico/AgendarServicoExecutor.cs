using AutoMapper;
using Doggis.Domain.Entities;
using Doggis.Domain.IRepository;
using Doggis.ExecutorsAbstraction.Abstraction;
using Doggis.ExecutorsAbstraction.ExecutorsTypes.Parameters.Servico;
using Doggis.ExecutorsAbstraction.ExecutorsTypes.Results.Servico;
using System.Threading.Tasks;

namespace Doggis.Executors.Servico
{
    public class AgendarServicoExecutor : IExecutor<AgendarServicoParameter, AgendarServicoResult>
    {
        private readonly IServicoRepository _servicoRepository;
        private readonly IMapper _mapper;

        public AgendarServicoExecutor(IServicoRepository servicoRepository, IMapper mapper)
        {
            _mapper = mapper;
            _servicoRepository = servicoRepository;
        }

        public async Task<AgendarServicoResult> Execute(AgendarServicoParameter parameter)
        {
            var agendaServico = _mapper.Map<AgendaServico>(parameter.AgendaServico);

            await _servicoRepository.AgendarServico(agendaServico);

            return new AgendarServicoResult();
        }
    }
}
