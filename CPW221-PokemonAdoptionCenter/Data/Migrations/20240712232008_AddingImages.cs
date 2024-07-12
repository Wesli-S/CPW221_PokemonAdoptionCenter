using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CPW221_PokemonAdoptionCenter.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddingImages : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageOfPokemon",
                table: "pokemons",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "pokemons",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageOfPokemon",
                value: "/images/Placeholder.png");

            migrationBuilder.UpdateData(
                table: "pokemons",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageOfPokemon",
                value: "/images/Placeholder.png");

            migrationBuilder.UpdateData(
                table: "pokemons",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageOfPokemon",
                value: "/images/ICY-Apollo(Sylveon).jpg");

            migrationBuilder.UpdateData(
                table: "pokemons",
                keyColumn: "Id",
                keyValue: 4,
                column: "ImageOfPokemon",
                value: "/images/Placeholder.png");

            migrationBuilder.UpdateData(
                table: "pokemons",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Description", "ImageOfPokemon" },
                values: new object[] { "Cleo is one of the most bubbly Pokémon we've ever met (both figuratively and literally) She was dropped off by her previous owner who could no longer care for her.", "/images/Placeholder.png" });

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
                keyValue: 8,
                column: "ImageOfPokemon",
                value: "/images/Placeholder.png");

            migrationBuilder.UpdateData(
                table: "pokemons",
                keyColumn: "Id",
                keyValue: 9,
                column: "ImageOfPokemon",
                value: "/images/Placeholder.png");

            migrationBuilder.UpdateData(
                table: "pokemons",
                keyColumn: "Id",
                keyValue: 10,
                column: "ImageOfPokemon",
                value: "/images/Placeholder.png");

            migrationBuilder.UpdateData(
                table: "pokemons",
                keyColumn: "Id",
                keyValue: 11,
                column: "ImageOfPokemon",
                value: "/images/Placeholder.png");

            migrationBuilder.UpdateData(
                table: "pokemons",
                keyColumn: "Id",
                keyValue: 12,
                column: "ImageOfPokemon",
                value: "/images/Placeholder.png");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageOfPokemon",
                table: "pokemons");

            migrationBuilder.UpdateData(
                table: "pokemons",
                keyColumn: "Id",
                keyValue: 5,
                column: "Description",
                value: "Cleo is one of the most bubbly Pokémon we've ever met (both figuratively and literally) She was dropped off by her pervious owner who could no longer care for her.");
        }
    }
}
