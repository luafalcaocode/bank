using luafalcao.api.Domain.DTOs;
using luafalcao.api.Domain.Factories;
using luafalcao.api.Domain.Models;
using luafalcao.api.Shared.Utils;
using System;

namespace luafalcao.api.Domain.Facade
{
    public class CreditoFacade : ICreditoFacade
    {
        private Credito credito;

        public CreditoFacade()
        {
       
        }

        public Message<ResultadoCreditoDto> Contratar(CreditoDto creditoDto)
        {
            var message = new Message<ResultadoCreditoDto>();

            try
            {
                this.credito = CreditoSimpleFactory.ObterInstancia(creditoDto.Tipo, creditoDto);

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
