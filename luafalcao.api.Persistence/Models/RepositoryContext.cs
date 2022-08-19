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

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Financiamento> Financiamentos { get; set; }
        public DbSet<Parcela> Parcelas { get; set; }
    }
}
