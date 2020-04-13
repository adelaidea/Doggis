using System;
using System.Threading.Tasks;
using Doggis.ExecutorsAbstraction.Abstraction;
using Doggis.ExecutorsAbstraction.ExecutorsTypes.Parameters.Pet;
using Doggis.ExecutorsAbstraction.ExecutorsTypes.Results.Pet;
using Microsoft.AspNetCore.Mvc;

namespace Doggis.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class PetController : ControllerBase
    {
        private readonly IExecutor<ListarPetsPorClienteParameter, ListarPetsPorClienteResult> _listarPetsPorClienteExecutor;

        public PetController(IExecutor<ListarPetsPorClienteParameter, ListarPetsPorClienteResult> listarPetsPorClienteExecutor)
        {
            _listarPetsPorClienteExecutor = listarPetsPorClienteExecutor;
        }

        [HttpGet]
        public async Task<IActionResult> ListarPetsPorCliente(Guid clienteId)
        {
            try
            {
                var pets = await _listarPetsPorClienteExecutor.Execute(new ListarPetsPorClienteParameter { ClienteId = clienteId });

                return Ok(pets);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }
}