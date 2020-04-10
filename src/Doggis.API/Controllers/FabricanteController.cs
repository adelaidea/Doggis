using System;
using System.Threading.Tasks;
using Doggis.ExecutorsAbstraction.Abstraction;
using Doggis.ExecutorsAbstraction.ExecutorsTypes.Results.Fabricante;
using Microsoft.AspNetCore.Mvc;

namespace Doggis.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class FabricanteController : ControllerBase
    {
        private readonly IExecutor<ListarFabricanteResult> _fabricanteExecutor;

        public FabricanteController(IExecutor<ListarFabricanteResult> fabricanteExecutor)
        {
            _fabricanteExecutor = fabricanteExecutor;
        }

        [HttpGet]
        public async Task<IActionResult> Listar()
        {
            try
            {
                var fabricantes = await _fabricanteExecutor.Execute();

                return Ok(fabricantes);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }
}