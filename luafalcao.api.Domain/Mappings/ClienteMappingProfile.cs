using AutoMapper;
using luafalcao.api.Domain.DTOs;
using luafalcao.api.Persistence.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace luafalcao.api.Domain.Mappings
{
    public class ClienteMappingProfile : Profile
    {
        public ClienteMappingProfile()
        {
            CreateMap<ClienteDto, Cliente>();
            CreateMap<Cliente, ClienteDto>();
        }
    }
}
