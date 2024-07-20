using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CPW221_PokemonAdoptionCenter.Data.Migrations
{
    /// <inheritdoc />
    public partial class NewPhotosYall : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "pokemons",
                keyColumn: "Id",
                keyValue: 10,
                column: "ImageOfPokemon",
                value: "/images/ICY-Theodore(Phantump).jpg");

            migrationBuilder.UpdateData(
                table: "pokemons",
                keyColumn: "Id",
                keyValue: 11,
                column: "ImageOfPokemon",
                value: "/images/ICY-Oakley(Espurr).jpg");

            migrationBuilder.UpdateData(
                table: "pokemons",
                keyColumn: "Id",
                keyValue: 12,
                column: "ImageOfPokemon",
                value: "/images/ICY-Jade(Kirlia).jpg");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
    }
}
