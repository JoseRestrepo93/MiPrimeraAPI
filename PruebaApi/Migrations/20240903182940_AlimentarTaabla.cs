using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PruebaApi.Migrations
{
    /// <inheritdoc />
    public partial class AlimentarTaabla : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<long>(
                name: "celular",
                table: "pruebas",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.InsertData(
                table: "pruebas",
                columns: new[] { "Id", "FechaCreacion", "Nombre", "apellido", "celular", "email" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 9, 3, 13, 29, 39, 645, DateTimeKind.Local).AddTicks(8923), "Jose", "Restrepo", 3196124005L, "jose.restrepo93@gmail.com" },
                    { 2, new DateTime(2024, 9, 3, 13, 29, 39, 645, DateTimeKind.Local).AddTicks(8939), "laura", "Camargo", 3046283763L, "lauraisabelcamargosalazar@gmail.com" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "pruebas",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "pruebas",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.AlterColumn<int>(
                name: "celular",
                table: "pruebas",
                type: "int",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");
        }
    }
}
