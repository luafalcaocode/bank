using luafalcao.api.Domain.Strategies;
using System;
using System.Collections.Generic;
using System.Text;

namespace luafalcao.api.Domain.Models
{
    public class CreditoImobiliario : Credito
    {
        public override double CalcularTaxaJuros()
        {
            return 0.09;
        }

        public CreditoImobiliario() : base(new ContratacaoCreditoComumStrategy())
        {

        }
    }
}
