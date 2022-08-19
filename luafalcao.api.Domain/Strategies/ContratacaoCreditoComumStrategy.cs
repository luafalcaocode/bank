using luafalcao.api.Domain.DTOs;
using luafalcao.api.Domain.Enums;
using luafalcao.api.Domain.Models;
using luafalcao.api.Domain.Validations;
using System;
using System.Globalization;
using System.Linq;

namespace luafalcao.api.Domain.Strategies
{
    public class ContratacaoCreditoComumStrategy : IContratacaoCreditoStrategy
    {
        public ResultadoCreditoDto Contratar(Credito credito)
        {
            var validacoes = CreditoValidationSingleton.GetInstance().ValidarCredito(credito);
            
            if (validacoes.Any())
            {
                return new ResultadoCreditoDto
                {
                    Success = false,
                    StatusCredito = "Reprovado",
                    Mensagens = validacoes
                };
            }

            return new ResultadoCreditoDto
            {
                Success = true,
                StatusCredito = "Aprovado",
                ValorDoJuros = (credito.Valor * credito.CalcularTaxaJuros()).ToString("C", new CultureInfo("pt-BR")),
                ValorTotalComJuros = (credito.Valor + (credito.Valor * credito.CalcularTaxaJuros())).ToString("C", new CultureInfo("pt-BR"))
            };           
        }
    }
}
