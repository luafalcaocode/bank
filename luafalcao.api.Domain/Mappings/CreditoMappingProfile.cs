using System;
using System.Collections.Generic;
using System.Text;

using AutoMapper;
using luafalcao.api.Domain.DTOs;
using luafalcao.api.Domain.Models;

namespace luafalcao.api.Domain.Mappings
{
    public class CreditoMappingProfile : Profile
    {
        public CreditoMappingProfile()
        {
            CreateMap<BaseDto, Credito>()
                .Include<CreditoDto, CreditoConsignado>()
                .Include<CreditoDto, CreditoDireto>()
                .Include<CreditoDto, CreditoPessoaFisica>()
                .Include<CreditoDto, CreditoPessoaJuridica>()
                .Include<CreditoDto, CreditoImobiliario>();

            CreateMap<CreditoDto, CreditoConsignado>();
            CreateMap<CreditoDto, CreditoDireto>();
            CreateMap<CreditoDto, CreditoPessoaFisica>();
            CreateMap<CreditoDto, CreditoPessoaJuridica>();
            CreateMap<CreditoDto, CreditoImobiliario>();
        }
    }
}
