using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace pokedex.Migrations
{
    public partial class initialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "jogadores",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    cidade = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    estado = table.Column<int>(type: "int", nullable: false),
                    idade = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_jogadores", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "pokemons",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tipo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    compra = table.Column<float>(type: "real", nullable: false),
                    venda = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pokemons", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "pokedexs",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    jogadorid = table.Column<int>(type: "int", nullable: true),
                    pokemonid = table.Column<int>(type: "int", nullable: true),
                    quantidade = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pokedexs", x => x.id);
                    table.ForeignKey(
                        name: "FK_pokedexs_jogadores_jogadorid",
                        column: x => x.jogadorid,
                        principalTable: "jogadores",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_pokedexs_pokemons_pokemonid",
                        column: x => x.pokemonid,
                        principalTable: "pokemons",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "transacoes",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    pokedexid = table.Column<int>(type: "int", nullable: true),
                    data = table.Column<DateTime>(type: "datetime2", nullable: false),
                    quantidade = table.Column<float>(type: "real", nullable: false),
                    valor = table.Column<float>(type: "real", nullable: false),
                    operacao = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_transacoes", x => x.id);
                    table.ForeignKey(
                        name: "FK_transacoes_pokedexs_pokedexid",
                        column: x => x.pokedexid,
                        principalTable: "pokedexs",
                        principalColumn: "id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_pokedexs_jogadorid",
                table: "pokedexs",
                column: "jogadorid");

            migrationBuilder.CreateIndex(
                name: "IX_pokedexs_pokemonid",
                table: "pokedexs",
                column: "pokemonid");

            migrationBuilder.CreateIndex(
                name: "IX_transacoes_pokedexid",
                table: "transacoes",
                column: "pokedexid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "transacoes");

            migrationBuilder.DropTable(
                name: "pokedexs");

            migrationBuilder.DropTable(
                name: "jogadores");

            migrationBuilder.DropTable(
                name: "pokemons");
        }
    }
}
