using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AspNetCore_EFCore_CodeFirst.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categoria",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "varchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categoria", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Livro",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false),
                    CategoriaID = table.Column<int>(type: "int", nullable: false),
                    Titulo = table.Column<string>(type: "varchar(150)", nullable: false),
                    Autor = table.Column<string>(type: "varchar(150)", nullable: false),
                    Quantidade = table.Column<int>(type: "int", nullable: false),
                    Preco = table.Column<decimal>(type: "numeric(38,2)", nullable: false),
                    DataEntrada = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Livro", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Livro_Categoria_CategoriaID",
                        column: x => x.CategoriaID,
                        principalTable: "Categoria",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categoria",
                columns: new[] { "ID", "Nome" },
                values: new object[] { 1, "Software" });

            migrationBuilder.InsertData(
                table: "Livro",
                columns: new[] { "ID", "Autor", "CategoriaID", "DataEntrada", "Preco", "Quantidade", "Titulo" },
                values: new object[,]
                {
                    { 1, "Eric Evans", 1, new DateTime(2021, 6, 22, 22, 12, 36, 860, DateTimeKind.Local).AddTicks(872), 59.90m, 26, "Domain-Driven Design: Tackling Complexity in the Heart of Software" },
                    { 2, "Robert C. Martin", 1, new DateTime(2021, 6, 22, 22, 12, 36, 861, DateTimeKind.Local).AddTicks(243), 45.90m, 13, "Agile Principles, Patterns, and Practices in C#" },
                    { 3, "Robert C. Martin", 1, new DateTime(2021, 6, 22, 22, 12, 36, 861, DateTimeKind.Local).AddTicks(257), 33.90m, 10, "Clean Code: A Handbook of Agile Software Craftsmanship" },
                    { 4, "Vaughn Vernon", 1, new DateTime(2021, 6, 22, 22, 12, 36, 861, DateTimeKind.Local).AddTicks(260), 59.90m, 22, "Implementing Domain-Driven Design" },
                    { 5, "Scott Millet", 1, new DateTime(2021, 6, 22, 22, 12, 36, 861, DateTimeKind.Local).AddTicks(261), 42.90m, 15, "Patterns, Principles, and Practices of Domain-Driven Design" },
                    { 6, "Martin Fowler", 1, new DateTime(2021, 6, 22, 22, 12, 36, 861, DateTimeKind.Local).AddTicks(263), 31.90m, 5, "Refactoring: Improving the Design of Existing Code" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Livro_CategoriaID",
                table: "Livro",
                column: "CategoriaID");

            migrationBuilder.CreateIndex(
                name: "IX_Livro_Titulo",
                table: "Livro",
                column: "Titulo");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Livro");

            migrationBuilder.DropTable(
                name: "Categoria");
        }
    }
}
