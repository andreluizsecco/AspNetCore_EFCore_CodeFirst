using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AspNetCore_EFCore_CodeFirst.Migrations
{
    public partial class Migration2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Livro_Categoria_CategoriaID",
                table: "Livro");

            migrationBuilder.UpdateData(
                table: "Livro",
                keyColumn: "ID",
                keyValue: 1,
                column: "DataEntrada",
                value: new DateTime(2021, 6, 22, 22, 20, 22, 301, DateTimeKind.Local).AddTicks(7691));

            migrationBuilder.UpdateData(
                table: "Livro",
                keyColumn: "ID",
                keyValue: 2,
                column: "DataEntrada",
                value: new DateTime(2021, 6, 22, 22, 20, 22, 302, DateTimeKind.Local).AddTicks(6753));

            migrationBuilder.UpdateData(
                table: "Livro",
                keyColumn: "ID",
                keyValue: 3,
                column: "DataEntrada",
                value: new DateTime(2021, 6, 22, 22, 20, 22, 302, DateTimeKind.Local).AddTicks(6769));

            migrationBuilder.UpdateData(
                table: "Livro",
                keyColumn: "ID",
                keyValue: 4,
                column: "DataEntrada",
                value: new DateTime(2021, 6, 22, 22, 20, 22, 302, DateTimeKind.Local).AddTicks(6771));

            migrationBuilder.UpdateData(
                table: "Livro",
                keyColumn: "ID",
                keyValue: 5,
                column: "DataEntrada",
                value: new DateTime(2021, 6, 22, 22, 20, 22, 302, DateTimeKind.Local).AddTicks(6824));

            migrationBuilder.UpdateData(
                table: "Livro",
                keyColumn: "ID",
                keyValue: 6,
                column: "DataEntrada",
                value: new DateTime(2021, 6, 22, 22, 20, 22, 302, DateTimeKind.Local).AddTicks(6826));

            migrationBuilder.AddForeignKey(
                name: "FK_Livro_Categoria_CategoriaID",
                table: "Livro",
                column: "CategoriaID",
                principalTable: "Categoria",
                principalColumn: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Livro_Categoria_CategoriaID",
                table: "Livro");

            migrationBuilder.UpdateData(
                table: "Livro",
                keyColumn: "ID",
                keyValue: 1,
                column: "DataEntrada",
                value: new DateTime(2021, 6, 22, 22, 12, 36, 860, DateTimeKind.Local).AddTicks(872));

            migrationBuilder.UpdateData(
                table: "Livro",
                keyColumn: "ID",
                keyValue: 2,
                column: "DataEntrada",
                value: new DateTime(2021, 6, 22, 22, 12, 36, 861, DateTimeKind.Local).AddTicks(243));

            migrationBuilder.UpdateData(
                table: "Livro",
                keyColumn: "ID",
                keyValue: 3,
                column: "DataEntrada",
                value: new DateTime(2021, 6, 22, 22, 12, 36, 861, DateTimeKind.Local).AddTicks(257));

            migrationBuilder.UpdateData(
                table: "Livro",
                keyColumn: "ID",
                keyValue: 4,
                column: "DataEntrada",
                value: new DateTime(2021, 6, 22, 22, 12, 36, 861, DateTimeKind.Local).AddTicks(260));

            migrationBuilder.UpdateData(
                table: "Livro",
                keyColumn: "ID",
                keyValue: 5,
                column: "DataEntrada",
                value: new DateTime(2021, 6, 22, 22, 12, 36, 861, DateTimeKind.Local).AddTicks(261));

            migrationBuilder.UpdateData(
                table: "Livro",
                keyColumn: "ID",
                keyValue: 6,
                column: "DataEntrada",
                value: new DateTime(2021, 6, 22, 22, 12, 36, 861, DateTimeKind.Local).AddTicks(263));

            migrationBuilder.AddForeignKey(
                name: "FK_Livro_Categoria_CategoriaID",
                table: "Livro",
                column: "CategoriaID",
                principalTable: "Categoria",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
