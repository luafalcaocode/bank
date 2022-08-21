using luafalcao.api.Persistence.Configurations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace luafalcao.api.Persistence.Models
{
    public class RepositoryContext : DbContext
    {
        public RepositoryContext(DbContextOptions options) : base(options)
        {
         
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new ClienteConfiguration());
            builder.ApplyConfiguration(new FinanciamentoConfiguration());
            builder.ApplyConfiguration(new FinanciamentoTipoConfiguration());
            builder.ApplyConfiguration(new ParcelaConfiguration());
        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Financiamento> Financiamentos { get; set; }
        public DbSet<FinanciamentoTipo> FinanciamentoTipo { get; set; }
        public DbSet<Parcela> Parcelas { get; set; }
    }
}
