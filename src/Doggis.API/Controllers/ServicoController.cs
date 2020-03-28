using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Doggis.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ServicoController : ControllerBase
    {
        [HttpGet]
        public IActionResult ListarServicos()
        {
            try
            {
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }
}