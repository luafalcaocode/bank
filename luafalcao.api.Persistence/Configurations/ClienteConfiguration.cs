using luafalcao.api.Persistence.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace luafalcao.api.Persistence.Configurations
{
    public class ClienteConfiguration : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.HasData(new Cliente
            {
                Id = 1,
                Celular = "21974737578",
                Cpf = "222222222222",
                Nome = "John Doe",
                UF = "RJ"
            },
            new Cliente
            {
                Id = 2,
                Celular = "21999999999",
                Cpf = "53751655115",
                Nome = "Jaina Proudmore",
                UF = "SP"
            },
            new Cliente
            {
                Id = 3,
                Celular = "21999999999",
                Cpf = "44831876941",
                Nome = "Arthas",
                UF = "SP"
            });
        }
    }
}
