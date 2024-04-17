using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CPW221_PokemonAdoptionCenter.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedMons : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "pokemons",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PokemonType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsAvailable = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pokemons", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "pokemons",
                columns: new[] { "Id", "Age", "Description", "IsAvailable", "Name", "PokemonType" },
                values: new object[,]
                {
                    { 1, 307, "Super sweet and a bit shy. Molla was found still in her ball after her owner had passed away, and now hopes to find a new playmate. She enjoys night walks and hide-and-seek", true, "Molla", "Haunter" },
                    { 2, 4, "Coming all the way from the Paldea region, Kinito has a naturally upbeat personality. Kinito enjoys swimming, splashing in puddles, and long afternoon naps.", true, "Kinito", "Paldean Wooper" },
                    { 3, 7, "Apollo was dropped off at our center by his owner who was 'displeased' about Apollo's evolutionary choices. Nevertheless, Apollo continues to be incredibly affectionate and loving.", true, "Apollo", "Sylveon (Shiny)" },
                    { 4, 10, "This Pokémon has been choosen! Best of luck, buddy!", false, "Captain Sushi", "Galarian Meowth" },
                    { 5, 8, "Cleo is one of the most bubbly Pokémon we've ever met (both figuratively and literally) She was dropped off by her pervious owner who could no longer care for her.", true, "Cleo", "Azumarill" },
                    { 6, 5, "Found tangled in beach debris. When she refused to return to the sea, she was brought to us to find a home. Chompee is incredibly affectionate and adores physical contact. Just watch out for those spikes, as they may hurt.", true, "Chompee", "Mareanie" },
                    { 7, 13, "This Pokémon has been choosen! Best of luck, buddy!", false, "Oliver", "Carnivine" },
                    { 8, 3, "This Pokémon has been choosen! Best of luck, buddy!", false, "Lilo", "Flabébé" },
                    { 9, 9, "Crystal spends most of his time in the pond behind our center, most often dozing or floating in circles. He will occasionally leave the pond to spend time with other Pokémon, but he most often prefers to loaf around. If you're looking for a good couch companion, this is your guy!", true, "Crystal", "Vaporeon" },
                    { 10, 102, "Found in an abandoned house, Theodore was brought into our care after it was determined he could not provide for himself in the wild. While he may seem incredibly shy and closed off at first, Theodore is actually very sweet once you get to know him.", true, "Theodore", "Phantump" },
                    { 11, 4, "Dropped off at our center as an egg, Oakley is fairly mild mannered and prefers to be alone most days. However, despite not wanting to play with the other Pokémon, Oakley will often be found close by to an employee, most often just watching as we go about our work.", true, "Oakley", "Espurr" },
                    { 12, 13, "This Pokémon is currently still in rehabilitation. Please be patient with her!", false, "Jade", "Kirlia" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "pokemons");
        }
    }
}
