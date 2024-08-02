using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CPW221_PokemonAdoptionCenter.Data.Migrations
{
    /// <inheritdoc />
    public partial class allpics : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "pokemons",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageOfPokemon",
                value: "/images/ICY-Molla(Haunter).jpg");

            migrationBuilder.UpdateData(
                table: "pokemons",
                keyColumn: "Id",
                keyValue: 5,
                column: "ImageOfPokemon",
                value: "/images/ICY-Cleo(Azumarill).jpg");

            migrationBuilder.UpdateData(
                table: "pokemons",
                keyColumn: "Id",
                keyValue: 6,
                column: "ImageOfPokemon",
                value: "/images/ICY-Chompee(Mareanie).jpg");

            migrationBuilder.UpdateData(
                table: "pokemons",
                keyColumn: "Id",
                keyValue: 7,
                column: "ImageOfPokemon",
                value: "/images/ICY-Oliver(Carnivine).jpg");

            migrationBuilder.UpdateData(
                table: "pokemons",
                keyColumn: "Id",
                keyValue: 9,
                column: "Description",
                value: "Crystal spends most of his time in the pond behind our center, most often dozing or floating in circles. He will occasionally leave the pond to spend time with other Pokémon, but he most often prefers to loaf around. If you're looking for a good couch companion, this may be your guy!");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "pokemons",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageOfPokemon",
                value: "/images/Placeholder.png");

            migrationBuilder.UpdateData(
                table: "pokemons",
                keyColumn: "Id",
                keyValue: 5,
                column: "ImageOfPokemon",
                value: "/images/Placeholder.png");

            migrationBuilder.UpdateData(
                table: "pokemons",
                keyColumn: "Id",
                keyValue: 6,
                column: "ImageOfPokemon",
                value: "/images/Placeholder.png");

            migrationBuilder.UpdateData(
                table: "pokemons",
                keyColumn: "Id",
                keyValue: 7,
                column: "ImageOfPokemon",
                value: "/images/Placeholder.png");

            migrationBuilder.UpdateData(
                table: "pokemons",
                keyColumn: "Id",
                keyValue: 9,
                column: "Description",
                value: "Crystal spends most of his time in the pond behind our center, most often dozing or floating in circles. He will occasionally leave the pond to spend time with other Pokémon, but he most often prefers to loaf around. If you're looking for a good couch companion, this is your guy!");
        }
    }
}
