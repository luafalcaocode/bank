using luafalcao.api.Domain.Strategies;
using System;
using System.Collections.Generic;
using System.Text;

namespace luafalcao.api.Domain.Models
{
    public class CreditoPessoaFisica : Credito
    {
        public override double CalcularTaxaJuros()
        {
            return 0.03;
        }

        public CreditoPessoaFisica() : base(new ContratacaoCreditoComumStrategy())
        {

        }
    }
}
