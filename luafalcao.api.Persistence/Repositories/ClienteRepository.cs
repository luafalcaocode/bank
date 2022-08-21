using luafalcao.api.Persistence.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace luafalcao.api.Persistence.Repositories
{
    public class ClienteRepository : RepositoryBase<Cliente>, IClienteRepository
    {
        private RepositoryContext context;

        public ClienteRepository(RepositoryContext context) : base(context)
        {
            this.context = context;
        }

        public async Task<IEnumerable<Cliente>> ObterClientesComParcelasAtrasadas()
        {
            var clientes = await this.context.Clientes
                .FromSqlRaw("select top(4) c.clientId, c.nome, c.UF, c.Cpf, c.Celular from clientes c " +
                            "inner join financiamentos f " +
                            "on c.ClientId = f.ClienteId " +
                            "inner join parcelas p " +
                            "on p.FinanciamentoId = f.FinanciamentoId " +
                            "where p.DataVencimento > GETDATE() and p.DataPagamento is NULL;").ToListAsync();

            return clientes;
        }
    }
}
