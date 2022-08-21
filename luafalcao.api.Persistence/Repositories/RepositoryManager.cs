using luafalcao.api.Persistence.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace luafalcao.api.Persistence.Repositories
{
    public class RepositoryManager : IRepositoryManager
    {
        private IClienteRepository cliente;
        private RepositoryContext context;

        public RepositoryManager(RepositoryContext context)
        {
            this.context = context;
        }

        public IClienteRepository Cliente
        {
            get
            {
                if (cliente == null)
                {
                    cliente = new ClienteRepository(context);
                }

                return cliente;
            }
        }

        public async Task Commit()
        {
            await context.SaveChangesAsync();
        }
    }
}
