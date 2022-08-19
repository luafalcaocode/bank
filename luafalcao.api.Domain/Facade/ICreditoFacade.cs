using luafalcao.api.Domain.DTOs;
using luafalcao.api.Shared.Utils;

namespace luafalcao.api.Domain.Facade
{
    public interface ICreditoFacade
    {
        Message<ResultadoCreditoDto> Contratar(CreditoDto creditoDto);
    }
}
