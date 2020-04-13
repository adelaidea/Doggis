using System;
using System.Threading.Tasks;
using Doggis.ExecutorsAbstraction.Abstraction;
using Doggis.ExecutorsAbstraction.ExecutorsTypes.Parameters.Cliente;
using Doggis.ExecutorsAbstraction.ExecutorsTypes.Results.Cliente;
using Microsoft.AspNetCore.Mvc;

namespace Doggis.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private readonly IExecutor<IncluirClienteParameter, IncluirClienteResult> _incluirClienteExecutor;
        private readonly IExecutor<ObterClienteParameter, ObterClienteResult> _obterClienteExecutor;
        private readonly IExecutor<ListarClienteResult> _listarClienteExecutor;

        public ClienteController(IExecutor<IncluirClienteParameter, IncluirClienteResult> incluirClienteExecutor,
                                    IExecutor<ObterClienteParameter, ObterClienteResult> obterClienteExecutor,
                                    IExecutor<ListarClienteResult> listarClienteExecutor)
        {
            _incluirClienteExecutor = incluirClienteExecutor;
            _obterClienteExecutor = obterClienteExecutor;
            _listarClienteExecutor = listarClienteExecutor;
        }

        [HttpGet]
        public async Task<IActionResult> Listar() 
        {
            try
            {
                var clientes = await _listarClienteExecutor.Execute();

                return Ok(clientes);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
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