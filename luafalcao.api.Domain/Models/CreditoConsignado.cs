using luafalcao.api.Domain.Enums;
using luafalcao.api.Domain.Strategies;
using System;
using System.Collections.Generic;
using System.Text;

namespace luafalcao.api.Domain.Models
{
    public class CreditoConsignado : Credito
    {
        public CreditoConsignado() : base(new ContratacaoCreditoComumStrategy())
        {
            
        }

        public override double CalcularTaxaJuros()
        {
            return 0.01;
        }      
    }
}
