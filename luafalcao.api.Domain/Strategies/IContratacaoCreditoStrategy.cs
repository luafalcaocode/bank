using luafalcao.api.Domain.DTOs;
using luafalcao.api.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace luafalcao.api.Domain.Strategies
{
    public interface IContratacaoCreditoStrategy
    {
        public ResultadoCreditoDto Contratar(Credito credito);
    }
}
