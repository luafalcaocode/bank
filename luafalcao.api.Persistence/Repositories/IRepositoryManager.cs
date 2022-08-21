using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace luafalcao.api.Persistence.Repositories
{
    public interface IRepositoryManager
    {
        IClienteRepository Cliente { get; }

        Task Commit();
    }
}
