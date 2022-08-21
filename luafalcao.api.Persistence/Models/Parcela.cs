using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace luafalcao.api.Persistence.Models
{
    public class Parcela
    {
        [Column("ParcelaId")]
        public int Id { get; set; }
        public int NumeroParcela { get; set; }
        public double ValorParcela { get; set; }
        public DateTime? DataVencimento { get; set; }
        public DateTime? DataPagamento { get; set; }

        [ForeignKey(nameof(Financiamento))]
        public int FinanciamentoId { get; set; }
        public Financiamento Financiamento { get; set; }
    }
}
