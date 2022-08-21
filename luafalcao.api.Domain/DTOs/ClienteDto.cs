using System;
using System.Collections.Generic;
using System.Text;

namespace luafalcao.api.Domain.DTOs
{
    public class ClienteDto
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string UF { get; set; }
        public string Celular { get; set; }
    }
}
