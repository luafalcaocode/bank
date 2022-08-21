using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace luafalcao.api.Persistence.Models
{
    public class FinanciamentoTipo
    {
        [Column("FinanciamentoId")]
        public int Id { get; set; }
        public string Nome { get; set; }

        public Financiamento Financiamento { get; set; }
    }
}
