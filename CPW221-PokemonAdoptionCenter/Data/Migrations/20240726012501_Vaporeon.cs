using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CPW221_PokemonAdoptionCenter.Data.Migrations
{
    /// <inheritdoc />
    public partial class Vaporeon : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "pokemons",
                keyColumn: "Id",
                keyValue: 9,
                column: "ImageOfPokemon",
                value: "/images/ICY-Crystal(Vaporeon).jpg");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "pokemons",
                keyColumn: "Id",
                keyValue: 9,
                column: "ImageOfPokemon",
                value: "/images/Placeholder.png");
        }
    }
}
