using System;
using System.Threading.Tasks;
using Doggis.ExecutorsAbstraction.Abstraction;
using Doggis.ExecutorsAbstraction.ExecutorsTypes.Parameters.Funcionario;
using Doggis.ExecutorsAbstraction.ExecutorsTypes.Results.Funcionario;
using Microsoft.AspNetCore.Mvc;

namespace Doggis.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class FuncionarioController : ControllerBase
    {
        private readonly IExecutor<ListarFuncionarioPorTipoPetEServicoParameter, ListarFuncionarioPorTipoPetEServicoResult> _listarFuncionarioPorTipoPetEServicoExecutor;
        private readonly IExecutor<ObterHorariosProfissionalParameter, ObterHorariosProfissionalResult> _obterHorariosProfissionalExecutor;

        public FuncionarioController(IExecutor<ListarFuncionarioPorTipoPetEServicoParameter, ListarFuncionarioPorTipoPetEServicoResult> listarFuncionarioPorTipoPetEServicoExecutor,
                                        IExecutor<ObterHorariosProfissionalParameter, ObterHorariosProfissionalResult> obterHorariosProfissionalExecutor)
        {
            _listarFuncionarioPorTipoPetEServicoExecutor = listarFuncionarioPorTipoPetEServicoExecutor;
            _obterHorariosProfissionalExecutor = obterHorariosProfissionalExecutor;
        }

        [HttpGet]
        public async Task<IActionResult> ListarFuncionarioPorTipoPetEServico(int tipoPetId, Guid servicoId)
        {
            try
            {
                var funcionarios = await _listarFuncionarioPorTipoPetEServicoExecutor.Execute(new ListarFuncionarioPorTipoPetEServicoParameter { ServicoId = servicoId, TipoPetId = tipoPetId });

                return Ok(funcionarios);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpGet]
        public async Task<IActionResult> ObterHorariosProfissional(Guid funcionarioId, Guid servicoId, DateTime dia)
        {
            try
            {
                var horarios = await _obterHorariosProfissionalExecutor.Execute(new ObterHorariosProfissionalParameter { Dia = dia, FuncionarioId = funcionarioId, ServicoId = servicoId });

                return Ok(horarios);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }
}