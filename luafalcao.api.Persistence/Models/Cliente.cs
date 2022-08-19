using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace luafalcao.api.Persistence.Models
{
    public class Cliente
    {
        [Column("ClientId")]
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string UF { get; set; }
        public string Celular { get; set; }

        public ICollection<Financiamento> Financiamentos { get; set; }
    }
}
