using luafalcao.api.Domain.Enums;
using luafalcao.api.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace luafalcao.api.Domain.Factories
{
    public class CreditoSimpleFactory
    {
        public static Credito Criar(TipoCreditoEnum tipo, Credito credito)
        {
            switch(tipo)
            {
                case TipoCreditoEnum.Consignado:
                    return new CreditoConsignado(credito.Valor, credito.Tipo, credito.QuantidadeParcelas, credito.DataPrimeiroVencimento);
                case TipoCreditoEnum.Direto:
                    return new CreditoDireto();
                case TipoCreditoEnum.Imobiliario:
                    return new CreditoImobiliario();
                case TipoCreditoEnum.PessoaFisica:
                    return new CreditoPessoaFisica();
                case TipoCreditoEnum.PessoaJuridica:
                    return new CreditoPessoaJuridica();
                default:
                    return null;
            }
        }
    }
}
