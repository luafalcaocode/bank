using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace luafalcao.api.Persistence.Models
{
    public class Financiamento
    {
        [Column("FinanciamentoId")]
        public int Id { get; set; }
        public string TipoFinanciamento { get; set; }
        public double ValorTotal { get; set; }
        public DateTime DataUltimoVencimento { get; set; }


        [ForeignKey(nameof(Cliente))]
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }

        ICollection<Parcela> Parcelas { get; set; }
    }
}
