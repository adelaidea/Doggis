using Doggis.Domain.IRepository;
using Doggis.ExecutorsAbstraction.Abstraction;
using Doggis.ExecutorsAbstraction.ExecutorsTypes.Parameters.Funcionario;
using Doggis.ExecutorsAbstraction.ExecutorsTypes.Results.Funcionario;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Doggis.Executors.Funcionario
{
    public class ObterHorariosProfissionalExecutor : IExecutor<ObterHorariosProfissionalParameter, ObterHorariosProfissionalResult>
    {
        private readonly IFuncionarioRepository _funcionarioRepository;

        public ObterHorariosProfissionalExecutor(IFuncionarioRepository funcionarioRepository)
        {
            _funcionarioRepository = funcionarioRepository;
        }

        public async Task<ObterHorariosProfissionalResult> Execute(ObterHorariosProfissionalParameter parameter)
        {
            var dispobilidades = await _funcionarioRepository.GetDisponibilidade(parameter.FuncionarioId);

            var horariosDisponiveis = new List<string>();

            return new ObterHorariosProfissionalResult { Horarios = horariosDisponiveis };
        }
    }
}