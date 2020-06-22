using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace IndustriaAgroalimentaria.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Productos",
                columns: table => new
                {
                    Id = table.Column<uint>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    FechaCaducidad = table.Column<DateTime>(nullable: false),
                    NumeroLote = table.Column<int>(nullable: false),
                    FechaEnvasado = table.Column<DateTime>(nullable: false),
                    PaisOrigen = table.Column<string>(nullable: true),
                    Discriminator = table.Column<string>(nullable: false),
                    TemperaturaRecomendada = table.Column<string>(nullable: true),
                    GSPLA = table.Column<double>(nullable: true),
                    PorcentajeNitrogeno = table.Column<double>(nullable: true),
                    PorcentajeOxigeno = table.Column<double>(nullable: true),
                    PorcentajeDioxidoCarbono = table.Column<double>(nullable: true),
                    PorcentajeVaporAgua = table.Column<double>(nullable: true),
                    MetodoCongelacion = table.Column<string>(nullable: true),
                    ENPS = table.Column<string>(nullable: true),
                    COSA = table.Column<string>(nullable: true),
                    ProductoRefrigerado_TemperaturaRecomendada = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Productos", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Productos");
        }
    }
}
