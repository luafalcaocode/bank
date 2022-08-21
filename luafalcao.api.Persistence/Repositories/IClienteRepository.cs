using luafalcao.api.Persistence.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace luafalcao.api.Persistence.Repositories
{
    public interface IClienteRepository
    {
        Task<IEnumerable<Cliente>> ObterClientesComParcelasAtrasadas();
    }
}
