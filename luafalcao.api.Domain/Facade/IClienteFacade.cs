using luafalcao.api.Domain.DTOs;
using luafalcao.api.Persistence.Models;
using luafalcao.api.Shared.Utils;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace luafalcao.api.Domain.Facade
{
    public interface IClienteFacade
    {
        Task<Message<IEnumerable<ClienteDto>>> ObterClientesComParcelaEmAtraso();
    }
}
