using luafalcao.api.Domain.DTOs;
using luafalcao.api.Domain.Facade;
using Microsoft.AspNetCore.Mvc;

namespace luafalcao.api.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CreditosController : ControllerBase
    {
        private ICreditoFacade creditoFacade;

        public CreditosController(ICreditoFacade facade)
        {
            this.creditoFacade = facade;
        }

        [HttpPost]
        [Route("contrato")]
        public IActionResult ContratarCredito(CreditoDto creditoDto)
        {
            var message = this.creditoFacade.Contratar(creditoDto);
            return StatusCode(message.StatusCode, message);
        }
    }
}
