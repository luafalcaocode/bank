using luafalcao.api.Domain.Enums;
using luafalcao.api.Domain.Strategies;
using System;
using System.Collections.Generic;
using System.Text;

namespace luafalcao.api.Domain.Models
{
    public class CreditoConsignado : Credito
    {
        public CreditoConsignado(double valor, TipoCreditoEnum tipo, int quantidadeParcelas, DateTime dataPrimeiroVencimento) 
            : base(new ContratacaoCreditoComumStrategy())
        {
            Valor = valor;
            Tipo = tipo;
            QuantidadeParcelas = quantidadeParcelas;
            DataPrimeiroVencimento = dataPrimeiroVencimento;
        }

        public override double CalcularTaxaJuros()
        {
            return 0.01;
        }

        public CreditoConsignado() : base(new ContratacaoCreditoComumStrategy())
        {
            
        }
    }
}
