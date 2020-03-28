using System;
using System.Threading.Tasks;
using Doggis.ExecutorsAbstraction.Abstraction;
using Doggis.ExecutorsAbstraction.ExecutorsTypes.Parameters.Cliente;
using Doggis.ExecutorsAbstraction.ExecutorsTypes.Results.Cliente;
using Microsoft.AspNetCore.Mvc;

namespace Doggis.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private readonly IExecutor<IncluirClienteParameter, IncluirClienteResult> _incluirClienteExecutor;
        private readonly IExecutor<ObterClienteParameter, ObterClienteResult> _obterClienteExecutor;

        public ClienteController(IExecutor<IncluirClienteParameter, IncluirClienteResult> incluirClienteExecutor,
                                    IExecutor<ObterClienteParameter, ObterClienteResult> obterClienteExecutor)
        {
            _incluirClienteExecutor = incluirClienteExecutor;
            _obterClienteExecutor = obterClienteExecutor;
        }

        [HttpPost]
        public async Task<IActionResult> Incluir(IncluirClienteParameter parameter)
        {
            try
            {
                await _incluirClienteExecutor.Execute(parameter);

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpGet]
        public async Task<ActionResult<ObterClienteResult>> Obter(Guid id)
        {
            try
            {
                var parameter = new ObterClienteParameter { Id = id };
                var cliente = await _obterClienteExecutor.Execute(parameter);

                return cliente;
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }
}