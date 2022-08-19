using luafalcao.api.Domain.DTOs;
using luafalcao.api.Domain.Enums;
using luafalcao.api.Domain.Strategies;
using System;

namespace luafalcao.api.Domain.Models
{
    public abstract class Credito
    {
        IContratacaoCreditoStrategy contratacaoStrategy;

        public double Valor { get; set; }
        public TipoCreditoEnum Tipo { get; set; }
        public int QuantidadeParcelas { get; set; }
        public DateTime DataPrimeiroVencimento { get; set; }


        public Credito(IContratacaoCreditoStrategy contratacao) => this.contratacaoStrategy = contratacao;
        
        public void SetContratacaoCredito(IContratacaoCreditoStrategy contratacao) => this.contratacaoStrategy = contratacao;
       
        public abstract double CalcularTaxaJuros();

        public ResultadoCreditoDto Contratar()
        {
            return this.contratacaoStrategy.Contratar(this);
        }
    }
}
