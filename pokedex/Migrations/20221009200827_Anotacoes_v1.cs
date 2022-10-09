using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace pokedex.Migrations
{
    public partial class Anotacoes_v1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_pokedexs_jogadores_jogadorid",
                table: "pokedexs");

            migrationBuilder.DropForeignKey(
                name: "FK_pokedexs_pokemons_pokemonid",
                table: "pokedexs");

            migrationBuilder.DropForeignKey(
                name: "FK_transacoes_pokedexs_pokedexid",
                table: "transacoes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_transacoes",
                table: "transacoes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_pokemons",
                table: "pokemons");

            migrationBuilder.DropPrimaryKey(
                name: "PK_jogadores",
                table: "jogadores");

            migrationBuilder.DropPrimaryKey(
                name: "PK_pokedexs",
                table: "pokedexs");

            migrationBuilder.RenameTable(
                name: "transacoes",
                newName: "Transacoes");

            migrationBuilder.RenameTable(
                name: "pokemons",
                newName: "Pokemons");

            migrationBuilder.RenameTable(
                name: "jogadores",
                newName: "Jogadores");

            migrationBuilder.RenameTable(
                name: "pokedexs",
                newName: "Pokedex");

            migrationBuilder.RenameIndex(
                name: "IX_transacoes_pokedexid",
                table: "Transacoes",
                newName: "IX_Transacoes_pokedexid");

            migrationBuilder.RenameIndex(
                name: "IX_pokedexs_pokemonid",
                table: "Pokedex",
                newName: "IX_Pokedex_pokemonid");

            migrationBuilder.RenameIndex(
                name: "IX_pokedexs_jogadorid",
                table: "Pokedex",
                newName: "IX_Pokedex_jogadorid");

            migrationBuilder.AlterColumn<int>(
                name: "pokedexid",
                table: "Transacoes",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "tipo",
                table: "Pokemons",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "nome",
                table: "Jogadores",
                type: "nvarchar(40)",
                maxLength: 40,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "cidade",
                table: "Jogadores",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "pokemonid",
                table: "Pokedex",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "jogadorid",
                table: "Pokedex",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Transacoes",
                table: "Transacoes",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Pokemons",
                table: "Pokemons",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Jogadores",
                table: "Jogadores",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Pokedex",
                table: "Pokedex",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_Pokedex_Jogadores_jogadorid",
                table: "Pokedex",
                column: "jogadorid",
                principalTable: "Jogadores",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Pokedex_Pokemons_pokemonid",
                table: "Pokedex",
                column: "pokemonid",
                principalTable: "Pokemons",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Transacoes_Pokedex_pokedexid",
                table: "Transacoes",
                column: "pokedexid",
                principalTable: "Pokedex",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pokedex_Jogadores_jogadorid",
                table: "Pokedex");

            migrationBuilder.DropForeignKey(
                name: "FK_Pokedex_Pokemons_pokemonid",
                table: "Pokedex");

            migrationBuilder.DropForeignKey(
                name: "FK_Transacoes_Pokedex_pokedexid",
                table: "Transacoes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Transacoes",
                table: "Transacoes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Pokemons",
                table: "Pokemons");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Jogadores",
                table: "Jogadores");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Pokedex",
                table: "Pokedex");

            migrationBuilder.RenameTable(
                name: "Transacoes",
                newName: "transacoes");

            migrationBuilder.RenameTable(
                name: "Pokemons",
                newName: "pokemons");

            migrationBuilder.RenameTable(
                name: "Jogadores",
                newName: "jogadores");

            migrationBuilder.RenameTable(
                name: "Pokedex",
                newName: "pokedexs");

            migrationBuilder.RenameIndex(
                name: "IX_Transacoes_pokedexid",
                table: "transacoes",
                newName: "IX_transacoes_pokedexid");

            migrationBuilder.RenameIndex(
                name: "IX_Pokedex_pokemonid",
                table: "pokedexs",
                newName: "IX_pokedexs_pokemonid");

            migrationBuilder.RenameIndex(
                name: "IX_Pokedex_jogadorid",
                table: "pokedexs",
                newName: "IX_pokedexs_jogadorid");

            migrationBuilder.AlterColumn<int>(
                name: "pokedexid",
                table: "transacoes",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "tipo",
                table: "pokemons",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30);

            migrationBuilder.AlterColumn<string>(
                name: "nome",
                table: "jogadores",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(40)",
                oldMaxLength: 40);

            migrationBuilder.AlterColumn<string>(
                name: "cidade",
                table: "jogadores",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(25)",
                oldMaxLength: 25);

            migrationBuilder.AlterColumn<int>(
                name: "pokemonid",
                table: "pokedexs",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "jogadorid",
                table: "pokedexs",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddPrimaryKey(
                name: "PK_transacoes",
                table: "transacoes",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_pokemons",
                table: "pokemons",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_jogadores",
                table: "jogadores",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_pokedexs",
                table: "pokedexs",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_pokedexs_jogadores_jogadorid",
                table: "pokedexs",
                column: "jogadorid",
                principalTable: "jogadores",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_pokedexs_pokemons_pokemonid",
                table: "pokedexs",
                column: "pokemonid",
                principalTable: "pokemons",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_transacoes_pokedexs_pokedexid",
                table: "transacoes",
                column: "pokedexid",
                principalTable: "pokedexs",
                principalColumn: "id");
        }
    }
}
