using AutoMapper;
using Doggis.Domain.IRepository;
using Doggis.ExecutorsAbstraction.Abstraction;
using Doggis.ExecutorsAbstraction.ExecutorsTypes.Parameters.Servico;
using Doggis.ExecutorsAbstraction.ExecutorsTypes.Results.Servico;
using Doggis.ExecutorsAbstraction.Model.Servico;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Doggis.Executors.Servico
{
    public class ObterServicosAgendadosExecutor : IExecutor<ObterServicosAgendadosParameter, ObterServicosAgendadosResult>
    {
        private readonly IServicoRepository _servicoRepository;
        private readonly IMapper _mapper;

        public ObterServicosAgendadosExecutor(IMapper mapper, IServicoRepository servicoRepository)
        {
            _servicoRepository = servicoRepository;
            _mapper = mapper;
        }

        public async Task<ObterServicosAgendadosResult> Execute(ObterServicosAgendadosParameter parameter)
        {
            var servicos = await _servicoRepository.ObterServicosAgendadosDia(parameter.Data);

            var servicosModel = _mapper.Map<IEnumerable<AgendaServicoListaModel>>(servicos);

            return new ObterServicosAgendadosResult { ServicosAgendados = servicosModel };
        }
    }
}