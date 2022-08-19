using luafalcao.api.Domain.Enums;
using luafalcao.api.Domain.Models;

namespace luafalcao.api.Domain.Factories
{
    public class CreditoSimpleFactory
    {
        public static Credito Criar(TipoCreditoEnum tipo)
        {
            switch(tipo)
            {
                case TipoCreditoEnum.Consignado:
                    return new CreditoConsignado();
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
