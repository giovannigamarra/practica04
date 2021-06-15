using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Practica04.Migrations
{
    public partial class inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FormularioIngresos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreUsuario = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FormularioIngresos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FormularioRegistros",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    titulofoto = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    urlfoto = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    comentario = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    subidopor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaRegistro = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FormularioIngresoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FormularioRegistros", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FormularioRegistros_FormularioIngresos_FormularioIngresoId",
                        column: x => x.FormularioIngresoId,
                        principalTable: "FormularioIngresos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FormularioRegistros_FormularioIngresoId",
                table: "FormularioRegistros",
                column: "FormularioIngresoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FormularioRegistros");

            migrationBuilder.DropTable(
                name: "FormularioIngresos");
        }
    }
}
