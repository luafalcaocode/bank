using luafalcao.api.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace luafalcao.api.Domain.DTOs
{
    public class ResultadoCreditoDto
    {
        public bool Success { get; set; }
        public string StatusCredito { get; set; }
        public string ValorTotalComJuros { get; set; }
        public string ValorDoJuros { get; set; }
        public IList<string> Mensagens { get; set; }
    }
}
