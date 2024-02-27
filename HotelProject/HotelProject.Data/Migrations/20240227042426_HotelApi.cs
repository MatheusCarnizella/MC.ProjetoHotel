using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelProject.Data.Migrations
{
    /// <inheritdoc />
    public partial class HotelApi : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Hotel");

            migrationBuilder.CreateTable(
                name: "Quartos",
                schema: "Hotel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Andar = table.Column<int>(type: "int", nullable: false),
                    Manutencao = table.Column<bool>(type: "bit", nullable: false),
                    Alugado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Quartos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Usuario",
                schema: "Hotel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Aluguel",
                schema: "Hotel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AlugadoPor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Inicio = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Fim = table.Column<DateTime>(type: "datetime2", nullable: false),
                    QuartosId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Aluguel", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Aluguel_Quartos_QuartosId",
                        column: x => x.QuartosId,
                        principalSchema: "Hotel",
                        principalTable: "Quartos",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Aluguel_QuartosId",
                schema: "Hotel",
                table: "Aluguel",
                column: "QuartosId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Aluguel",
                schema: "Hotel");

            migrationBuilder.DropTable(
                name: "Usuario",
                schema: "Hotel");

            migrationBuilder.DropTable(
                name: "Quartos",
                schema: "Hotel");
        }
    }
}
