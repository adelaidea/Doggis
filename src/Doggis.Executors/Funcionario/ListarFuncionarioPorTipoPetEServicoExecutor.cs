using AutoMapper;
using Doggis.Domain.IRepository;
using Doggis.ExecutorsAbstraction.Abstraction;
using Doggis.ExecutorsAbstraction.ExecutorsTypes.Parameters.Funcionario;
using Doggis.ExecutorsAbstraction.ExecutorsTypes.Results.Funcionario;
using Doggis.ExecutorsAbstraction.Model.Funcionario;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Doggis.Executors.Funcionario
{
    public class ListarFuncionarioPorTipoPetEServicoExecutor : IExecutor<ListarFuncionarioPorTipoPetEServicoParameter, ListarFuncionarioPorTipoPetEServicoResult>
    {
        private readonly IMapper _mapper;
        private readonly IFuncionarioRepository _funcionarioRepository;

        public ListarFuncionarioPorTipoPetEServicoExecutor(IMapper mapper, IFuncionarioRepository funcionarioRepository)
        {
            _mapper = mapper;
            _funcionarioRepository = funcionarioRepository;
        }

        public async Task<ListarFuncionarioPorTipoPetEServicoResult> Execute(ListarFuncionarioPorTipoPetEServicoParameter parameter)
        {
            var funcionarios = await _funcionarioRepository.Find(x => x.TiposPet.Any(tp => tp.TipoPetId == parameter.TipoPetId) &&
                                                                        x.Servicos.Any(s => s.ServicoId == parameter.ServicoId));

            return new ListarFuncionarioPorTipoPetEServicoResult { Funcionarios = _mapper.Map<IEnumerable<FuncionarioModel>>(funcionarios).OrderBy(x => x.Nome) };
        }
    }
}