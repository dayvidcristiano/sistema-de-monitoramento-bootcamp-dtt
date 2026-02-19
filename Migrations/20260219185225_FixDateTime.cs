using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace sistema_de_monitoramento.Migrations
{
    /// <inheritdoc />
    public partial class FixDateTime : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Equipamentos_Codigo",
                table: "Equipamentos");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataAquisicao",
                table: "Equipamentos",
                type: "timestamp without time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DataAquisicao",
                table: "Equipamentos",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone");

            migrationBuilder.CreateIndex(
                name: "IX_Equipamentos_Codigo",
                table: "Equipamentos",
                column: "Codigo",
                unique: true);
        }
    }
}
