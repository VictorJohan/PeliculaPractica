using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RegistroPeliculas.Migrations
{
    public partial class Migracion_Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Peliculas",
                columns: table => new
                {
                    IdPelicula = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    NombrePelicula = table.Column<string>(nullable: true),
                    Sipnosis = table.Column<string>(nullable: true),
                    Genero = table.Column<string>(nullable: true),
                    FechaEstreno = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Peliculas", x => x.IdPelicula);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Peliculas");
        }
    }
}
