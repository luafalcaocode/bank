using luafalcao.api.Domain.Enums;
using System;

namespace luafalcao.api.Domain.DTOs
{
    public class CreditoDto : BaseDto
    {
        public double Valor { get; set; }
        public TipoCreditoEnum Tipo { get; set; }
        public int QuantidadeParcelas { get; set; }
        public DateTime DataPrimeiroVencimento { get; set; }
    }
}
