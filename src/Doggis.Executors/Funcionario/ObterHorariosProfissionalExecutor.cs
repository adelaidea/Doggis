using Doggis.Domain.IRepository;
using Doggis.ExecutorsAbstraction.Abstraction;
using Doggis.ExecutorsAbstraction.ExecutorsTypes.Parameters.Funcionario;
using Doggis.ExecutorsAbstraction.ExecutorsTypes.Results.Funcionario;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Doggis.Executors.Funcionario
{
    public class ObterHorariosProfissionalExecutor : IExecutor<ObterHorariosProfissionalParameter, ObterHorariosProfissionalResult>
    {
        private readonly IFuncionarioRepository _funcionarioRepository;
        private readonly IServicoRepository _servicoRepository;

        public ObterHorariosProfissionalExecutor(IFuncionarioRepository funcionarioRepository, IServicoRepository servicoRepository)
        {
            _funcionarioRepository = funcionarioRepository;
            _servicoRepository = servicoRepository;
        }

        public async Task<ObterHorariosProfissionalResult> Execute(ObterHorariosProfissionalParameter parameter)
        {
            int diaSemana = (int)parameter.Dia.DayOfWeek + 1;

            var dispobilidades = (await _funcionarioRepository.GetDisponibilidade(parameter.FuncionarioId)).Where(x => x.DiaSemana == diaSemana);
            var horariosAgendados = (await _servicoRepository.ObterServicosAgendadosDia(parameter.Dia)).Where(x => x.FuncionarioId == parameter.FuncionarioId).Select(x => x.DataRealizacao.TimeOfDay);

            var result = new List<string>();

            var disponibilidadesValidas = dispobilidades.Where(x => !horariosAgendados.Contains(x.HorarioInicio)).ToList();

            disponibilidadesValidas.ForEach(x => result.Add($"{x.HorarioInicio} - {x.HorarioFim}"));

            return new ObterHorariosProfissionalResult { Horarios = result };
        }
    }
}