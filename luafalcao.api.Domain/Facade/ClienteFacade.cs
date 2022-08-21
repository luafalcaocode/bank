using AutoMapper;
using luafalcao.api.Domain.DTOs;
using luafalcao.api.Domain.Services;
using luafalcao.api.Persistence.Models;
using luafalcao.api.Shared.Adapters;
using luafalcao.api.Shared.Mapper.Enums;
using luafalcao.api.Shared.Mapper.Factories;
using luafalcao.api.Shared.Utils;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace luafalcao.api.Domain.Facade
{
    public class ClienteFacade : IClienteFacade
    {
        private IMapperManager mapper;
        private IClienteService clienteService;

        public ClienteFacade(IClienteService clienteService)
        {
            this.mapper = MapperManagerFactory.Create(MapperTypeEnum.AutoMapper); ;
            this.clienteService = clienteService;
        }

        public async Task<Message<IEnumerable<ClienteDto>>> ObterClientesComParcelaEmAtraso()
        {
            var message = new Message<IEnumerable<ClienteDto>>();

            try
            {
                var resultado = this.mapper.Map<IEnumerable<Cliente>, IEnumerable<ClienteDto>>(await this.clienteService.ObterClientesComParcelasEmAtraso());

                if (resultado == null)
                {
                    message.NotFound();

                    return message;
                }

                message.Ok(resultado);
            }
            catch(Exception exception)
            {
                message.Error(exception);
            }

            return message;
        }
    }
}
