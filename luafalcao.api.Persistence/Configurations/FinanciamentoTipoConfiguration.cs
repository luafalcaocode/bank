using luafalcao.api.Persistence.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace luafalcao.api.Persistence.Configurations
{
    public class FinanciamentoTipoConfiguration : IEntityTypeConfiguration<FinanciamentoTipo>
    {
        public void Configure(EntityTypeBuilder<FinanciamentoTipo> builder)
        {
            builder.HasData(new FinanciamentoTipo
            {
                Id = 1,
                Nome = "SFH"
            },
            new FinanciamentoTipo
            {
                Id = 2,
                Nome = "SFI"
            },
            new FinanciamentoTipo
            {
                Id = 3,
                Nome = "SAC"
            },
            new FinanciamentoTipo
            {
                Id = 4,
                Nome = "Sacre"
            });
        }
    }
}
