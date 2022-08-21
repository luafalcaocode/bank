using luafalcao.api.Persistence.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace luafalcao.api.Persistence.Configurations
{
    public class FinanciamentoConfiguration : IEntityTypeConfiguration<Financiamento>
    {
        public void Configure(EntityTypeBuilder<Financiamento> builder)
        {
            builder.HasData(new Financiamento
            {
                Id = 1,
                ClienteId = 1,
                DataUltimoVencimento = DateTime.Now.AddDays(20),
                FinanciamentoTipoId = 1,
                ValorTotal = 35000.95
            },
            new Financiamento
            {
                Id = 2,
                ClienteId = 2,
                DataUltimoVencimento = DateTime.Now.AddDays(20),
                FinanciamentoTipoId = 2,
                ValorTotal = 4000
            });
        }
    }
}
