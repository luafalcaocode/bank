using luafalcao.api.Domain.Facade;
using luafalcao.api.Domain.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace luafalcao.api.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientesController : ControllerBase
    {
        private IClienteFacade clienteFacade;

        public ClientesController(IClienteFacade facade)
        {
            this.clienteFacade = facade;
        }

        [HttpGet]
        [Route("atrasados")]
        public async Task<IActionResult> ObterClientesComParcelasEmAtraso()
        {
            var message = await this.clienteFacade.ObterClientesComParcelaEmAtraso();
            return StatusCode(message.StatusCode, message);
        }
    }
}
