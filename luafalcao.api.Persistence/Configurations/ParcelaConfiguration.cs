using luafalcao.api.Persistence.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace luafalcao.api.Persistence.Configurations
{
    public class ParcelaConfiguration : IEntityTypeConfiguration<Parcela>
    {
        public void Configure(EntityTypeBuilder<Parcela> builder)
        {
            builder.HasData(new Parcela
            {
                Id = 1,
                DataPagamento = DateTime.Now.AddDays(10),
                DataVencimento = DateTime.Now.AddMonths(1),
                FinanciamentoId = 1,
                NumeroParcela = 20,
                ValorParcela = 500                
            },
            new Parcela
            {
                Id = 2,
                DataPagamento = DateTime.Now.AddDays(10),
                DataVencimento = DateTime.Now.AddMonths(1),
                FinanciamentoId = 2,
                NumeroParcela = 15,
                ValorParcela = 255.25
            },
             new Parcela
             {
                 Id = 3,
                 DataPagamento = null,
                 DataVencimento = DateTime.Now.AddMonths(1),
                 FinanciamentoId = 2,
                 NumeroParcela = 15,
                 ValorParcela = 255.25
             },
            new Parcela
            {
                Id = 4,
                DataPagamento = null,
                DataVencimento = DateTime.Now.AddMonths(2),
                FinanciamentoId = 2,
                NumeroParcela = 30,
                ValorParcela = 2500.25
            });
        }
    }
}
