using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CPW221_PokemonAdoptionCenter.Data.Migrations
{
    /// <inheritdoc />
    public partial class BattleMon : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "BattleType",
                table: "pokemons",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "pokemons",
                keyColumn: "Id",
                keyValue: 1,
                column: "BattleType",
                value: "Poison/Ghost");

            migrationBuilder.UpdateData(
                table: "pokemons",
                keyColumn: "Id",
                keyValue: 2,
                column: "BattleType",
                value: "Poison/Ground");

            migrationBuilder.UpdateData(
                table: "pokemons",
                keyColumn: "Id",
                keyValue: 3,
                column: "BattleType",
                value: "Fairy");

            migrationBuilder.UpdateData(
                table: "pokemons",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "BattleType", "Description" },
                values: new object[] { "Steel", "This Pokémon has been chosen! Best of luck, buddy!" });

            migrationBuilder.UpdateData(
                table: "pokemons",
                keyColumn: "Id",
                keyValue: 5,
                column: "BattleType",
                value: "Fairy/Water");

            migrationBuilder.UpdateData(
                table: "pokemons",
                keyColumn: "Id",
                keyValue: 6,
                column: "BattleType",
                value: "Poison/Water");

            migrationBuilder.UpdateData(
                table: "pokemons",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "BattleType", "Description" },
                values: new object[] { "Grass", "This Pokémon has been chosen! Best of luck, buddy!" });

            migrationBuilder.UpdateData(
                table: "pokemons",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "BattleType", "Description" },
                values: new object[] { "Grass", "This Pokémon has been chosen! Best of luck, buddy!" });

            migrationBuilder.UpdateData(
                table: "pokemons",
                keyColumn: "Id",
                keyValue: 9,
                column: "BattleType",
                value: "Water");

            migrationBuilder.UpdateData(
                table: "pokemons",
                keyColumn: "Id",
                keyValue: 10,
                column: "BattleType",
                value: "Grass/Ghost");

            migrationBuilder.UpdateData(
                table: "pokemons",
                keyColumn: "Id",
                keyValue: 11,
                column: "BattleType",
                value: "Psychic");

            migrationBuilder.UpdateData(
                table: "pokemons",
                keyColumn: "Id",
                keyValue: 12,
                column: "BattleType",
                value: "Psychic/Fairy");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BattleType",
                table: "pokemons");

            migrationBuilder.UpdateData(
                table: "pokemons",
                keyColumn: "Id",
                keyValue: 4,
                column: "Description",
                value: "This Pokémon has been choosen! Best of luck, buddy!");

            migrationBuilder.UpdateData(
                table: "pokemons",
                keyColumn: "Id",
                keyValue: 7,
                column: "Description",
                value: "This Pokémon has been choosen! Best of luck, buddy!");

            migrationBuilder.UpdateData(
                table: "pokemons",
                keyColumn: "Id",
                keyValue: 8,
                column: "Description",
                value: "This Pokémon has been choosen! Best of luck, buddy!");
        }
    }
}
