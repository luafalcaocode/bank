using luafalcao.api.Persistence.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace luafalcao.api.Domain.Services
{
    public interface IClienteService
    {
        public Task<IEnumerable<Cliente>> ObterClientesComParcelasEmAtraso();
    }
}
