using luafalcao.api.Domain.DTOs;
using luafalcao.api.Domain.Enums;
using luafalcao.api.Domain.Models;
using luafalcao.api.Shared.Adapters;
using luafalcao.api.Shared.Mapper.Enums;
using luafalcao.api.Shared.Mapper.Factories;

namespace luafalcao.api.Domain.Factories
{
    public class CreditoSimpleFactory
    {
        public static Credito Criar(TipoCreditoEnum tipo, BaseDto dataTransferObject = null)
        {
            IMapperManager mapper = MapperManagerFactory.Create(MapperTypeEnum.AutoMapper);

            if (dataTransferObject == null)
                return Criar(tipo);
            else
                return Criar(mapper, tipo, dataTransferObject);                
        }

        private static Credito Criar(IMapperManager mapper, TipoCreditoEnum tipo, BaseDto dataTransferObject = null)
        {
            switch(tipo)
            {
                case TipoCreditoEnum.Consignado:
                    return mapper.Map<BaseDto, CreditoConsignado>(dataTransferObject);
                case TipoCreditoEnum.Direto:
                    return mapper.Map<BaseDto, CreditoDireto>(dataTransferObject);
                case TipoCreditoEnum.PessoaFisica:
                    return mapper.Map<BaseDto, CreditoPessoaFisica>(dataTransferObject);
                case TipoCreditoEnum.PessoaJuridica:
                    return mapper.Map<BaseDto, CreditoPessoaJuridica>(dataTransferObject);
                case TipoCreditoEnum.Imobiliario:
                    return mapper.Map<BaseDto, CreditoImobiliario>(dataTransferObject);
            }

            return null;
        }

        private static Credito Criar(TipoCreditoEnum tipo)
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
