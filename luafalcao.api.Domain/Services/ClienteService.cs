using luafalcao.api.Persistence.Models;
using luafalcao.api.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace luafalcao.api.Domain.Services
{
    public class ClienteService : IClienteService
    {
        private IRepositoryManager repositorio;

        public ClienteService(IRepositoryManager repositorio)
        {
            this.repositorio = repositorio;
        }

        public async Task<IEnumerable<Cliente>> ObterClientesComParcelasEmAtraso()
        {
            var clientes = await this.repositorio.Cliente.ObterClientesComParcelasAtrasadas();
            
            return clientes;
        }
    }
}
