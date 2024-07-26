using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CPW221_PokemonAdoptionCenter.Data.Migrations
{
    /// <inheritdoc />
    public partial class Meowth : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "pokemons",
                keyColumn: "Id",
                keyValue: 4,
                column: "ImageOfPokemon",
                value: "/images/ICY-CaptainSushi(GMeowth).jpg");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "pokemons",
                keyColumn: "Id",
                keyValue: 4,
                column: "ImageOfPokemon",
                value: "/images/Placeholder.png");
        }
    }
}
