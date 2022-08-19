using luafalcao.api.Domain.DTOs;
using luafalcao.api.Domain.Factories;
using luafalcao.api.Domain.Models;
using luafalcao.api.Shared.Adapters;
using luafalcao.api.Shared.Mapper.Enums;
using luafalcao.api.Shared.Mapper.Factories;
using luafalcao.api.Shared.Utils;
using System;

namespace luafalcao.api.Domain.Facade
{
    public class CreditoFacade : ICreditoFacade
    {
        private Credito credito;

        private IMapperManager mapper;

        public CreditoFacade()
        {
            this.mapper = MapperManagerFactory.Create(MapperTypeEnum.AutoMapper);
        }

        public Message<ResultadoCreditoDto> Contratar(CreditoDto creditoDto)
        {
            var message = new Message<ResultadoCreditoDto>();

            try
            {
                this.credito = CreditoSimpleFactory.Criar(creditoDto.Tipo, creditoDto);

                var resultado = this.credito.Contratar();
            
                if (!resultado.Success)
                {
                    message.BadRequest(resultado.Mensagens);

                    return message;
                }

                message.Ok(resultado);
            }
            catch (Exception exception)
            {
                message.Error(exception);
            }

            return message;
        }
    }
}
