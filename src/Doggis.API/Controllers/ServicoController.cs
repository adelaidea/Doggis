using System;
using System.Threading.Tasks;
using Doggis.ExecutorsAbstraction.Abstraction;
using Doggis.ExecutorsAbstraction.ExecutorsTypes.Parameters.Servico;
using Doggis.ExecutorsAbstraction.ExecutorsTypes.Results.Servico;
using Microsoft.AspNetCore.Mvc;

namespace Doggis.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ServicoController : ControllerBase
    {
        private readonly IExecutor<ObterServicosAgendadosParameter, ObterServicosAgendadosResult> _obterServicosAgendadosExecutor;
        private readonly IExecutor<ListarServicoResult> _listarServicoExecutor;

        public ServicoController(IExecutor<ObterServicosAgendadosParameter, ObterServicosAgendadosResult> obterServicosAgendadosExecutor,
                                    IExecutor<ListarServicoResult> listarServicoExecutor)
        {
            _obterServicosAgendadosExecutor = obterServicosAgendadosExecutor;
            _listarServicoExecutor = listarServicoExecutor;
        }

        [HttpGet]
        public async Task<IActionResult> ListarServicosAgendados(DateTime? data)
        {
            try
            {
                if (data == null)
                    data = DateTime.Now;

                var servicos = await _obterServicosAgendadosExecutor.Execute(new ObterServicosAgendadosParameter { Data = data.Value });

                return Ok(servicos.ServicosAgendados);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpGet]
        public async Task<IActionResult> Listar()
        {
            try
            {
                var servicos = await _listarServicoExecutor.Execute();

                return Ok(servicos);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }
}