using luafalcao.api.Domain.Strategies;
using System;
using System.Collections.Generic;
using System.Text;

namespace luafalcao.api.Domain.Models
{
    public class CreditoPessoaJuridica : Credito
    {
        public override double CalcularTaxaJuros()
        {
            return 0.05;
        }

        public CreditoPessoaJuridica() : base(new ContratacaoCreditoComumStrategy())
        {

        }
    }
}
