using luafalcao.api.Domain.Strategies;
using System;
using System.Collections.Generic;
using System.Text;

namespace luafalcao.api.Domain.Models
{
    public class CreditoDireto : Credito
    {
        public override double CalcularTaxaJuros()
        {
            return 0.02;
        }

        public CreditoDireto() : base(new ContratacaoCreditoComumStrategy())
        {

        }
    }
}
