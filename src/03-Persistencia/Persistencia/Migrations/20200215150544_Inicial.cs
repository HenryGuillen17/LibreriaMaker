using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistencia.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Editorial",
                columns: table => new
                {
                    IdEditorial = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Editorial", x => x.IdEditorial);
                });

            migrationBuilder.CreateTable(
                name: "Libro",
                columns: table => new
                {
                    IdLibro = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Titulo = table.Column<string>(maxLength: 50, nullable: false),
                    IdEditorial = table.Column<int>(nullable: false),
                    Fecha = table.Column<DateTime>(type: "date", nullable: false),
                    Costo = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    PrecioSugerido = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    Autor = table.Column<string>(maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Libro", x => x.IdLibro);
                    table.ForeignKey(
                        name: "FK_Libro_Editorial_IdEditorial",
                        column: x => x.IdEditorial,
                        principalTable: "Editorial",
                        principalColumn: "IdEditorial",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Libro_IdEditorial",
                table: "Libro",
                column: "IdEditorial");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Libro");

            migrationBuilder.DropTable(
                name: "Editorial");
        }
    }
}
