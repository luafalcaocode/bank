using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace luafalcao.api.Persistence.Migrations
{
    public partial class CriandoBancoDeDados : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    ClientId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(nullable: true),
                    Cpf = table.Column<string>(nullable: true),
                    UF = table.Column<string>(nullable: true),
                    Celular = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.ClientId);
                });

            migrationBuilder.CreateTable(
                name: "FinanciamentoTipo",
                columns: table => new
                {
                    FinanciamentoId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FinanciamentoTipo", x => x.FinanciamentoId);
                });

            migrationBuilder.CreateTable(
                name: "Financiamentos",
                columns: table => new
                {
                    FinanciamentoId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ValorTotal = table.Column<double>(nullable: false),
                    DataUltimoVencimento = table.Column<DateTime>(nullable: false),
                    ClienteId = table.Column<int>(nullable: false),
                    FinanciamentoTipoId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Financiamentos", x => x.FinanciamentoId);
                    table.ForeignKey(
                        name: "FK_Financiamentos_Clientes_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Clientes",
                        principalColumn: "ClientId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Financiamentos_FinanciamentoTipo_FinanciamentoTipoId",
                        column: x => x.FinanciamentoTipoId,
                        principalTable: "FinanciamentoTipo",
                        principalColumn: "FinanciamentoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Parcelas",
                columns: table => new
                {
                    ParcelaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumeroParcela = table.Column<int>(nullable: false),
                    ValorParcela = table.Column<double>(nullable: false),
                    DataVencimento = table.Column<DateTime>(nullable: true),
                    DataPagamento = table.Column<DateTime>(nullable: true),
                    FinanciamentoId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parcelas", x => x.ParcelaId);
                    table.ForeignKey(
                        name: "FK_Parcelas_Financiamentos_FinanciamentoId",
                        column: x => x.FinanciamentoId,
                        principalTable: "Financiamentos",
                        principalColumn: "FinanciamentoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Clientes",
                columns: new[] { "ClientId", "Celular", "Cpf", "Nome", "UF" },
                values: new object[,]
                {
                    { 1, "21974737578", "222222222222", "John Doe", "RJ" },
                    { 2, "21999999999", "53751655115", "Jaina Proudmore", "SP" },
                    { 3, "21999999999", "44831876941", "Arthas", "SP" }
                });

            migrationBuilder.InsertData(
                table: "FinanciamentoTipo",
                columns: new[] { "FinanciamentoId", "Nome" },
                values: new object[,]
                {
                    { 1, "SFH" },
                    { 2, "SFI" },
                    { 3, "SAC" },
                    { 4, "Sacre" }
                });

            migrationBuilder.InsertData(
                table: "Financiamentos",
                columns: new[] { "FinanciamentoId", "ClienteId", "DataUltimoVencimento", "FinanciamentoTipoId", "ValorTotal" },
                values: new object[] { 1, 1, new DateTime(2022, 9, 10, 14, 24, 33, 307, DateTimeKind.Local).AddTicks(3029), 1, 35000.949999999997 });

            migrationBuilder.InsertData(
                table: "Financiamentos",
                columns: new[] { "FinanciamentoId", "ClienteId", "DataUltimoVencimento", "FinanciamentoTipoId", "ValorTotal" },
                values: new object[] { 2, 2, new DateTime(2022, 9, 10, 14, 24, 33, 309, DateTimeKind.Local).AddTicks(1752), 2, 4000.0 });

            migrationBuilder.InsertData(
                table: "Parcelas",
                columns: new[] { "ParcelaId", "DataPagamento", "DataVencimento", "FinanciamentoId", "NumeroParcela", "ValorParcela" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 8, 31, 14, 24, 33, 310, DateTimeKind.Local).AddTicks(6083), new DateTime(2022, 9, 21, 14, 24, 33, 312, DateTimeKind.Local).AddTicks(8121), 1, 20, 500.0 },
                    { 2, new DateTime(2022, 8, 31, 14, 24, 33, 312, DateTimeKind.Local).AddTicks(9928), new DateTime(2022, 9, 21, 14, 24, 33, 312, DateTimeKind.Local).AddTicks(9950), 2, 15, 255.25 },
                    { 3, null, new DateTime(2022, 9, 21, 14, 24, 33, 313, DateTimeKind.Local).AddTicks(14), 2, 15, 255.25 },
                    { 4, null, new DateTime(2022, 10, 21, 14, 24, 33, 313, DateTimeKind.Local).AddTicks(17), 2, 30, 2500.25 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Financiamentos_ClienteId",
                table: "Financiamentos",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_Financiamentos_FinanciamentoTipoId",
                table: "Financiamentos",
                column: "FinanciamentoTipoId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Parcelas_FinanciamentoId",
                table: "Parcelas",
                column: "FinanciamentoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Parcelas");

            migrationBuilder.DropTable(
                name: "Financiamentos");

            migrationBuilder.DropTable(
                name: "Clientes");

            migrationBuilder.DropTable(
                name: "FinanciamentoTipo");
        }
    }
}
