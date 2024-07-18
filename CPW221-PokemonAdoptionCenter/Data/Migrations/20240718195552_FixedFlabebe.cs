﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CPW221_PokemonAdoptionCenter.Data.Migrations
{
    /// <inheritdoc />
    public partial class FixedFlabebe : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "pokemons",
                keyColumn: "Id",
                keyValue: 8,
                column: "ImageOfPokemon",
                value: "/images/ICY-Lilo(Flabebe).jpg");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "pokemons",
                keyColumn: "Id",
                keyValue: 8,
                column: "ImageOfPokemon",
                value: "/images/ICY-Lilo(Flababe).jpg");
        }
    }
}
