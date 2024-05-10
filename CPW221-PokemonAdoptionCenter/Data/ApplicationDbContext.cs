using CPW221_PokemonAdoptionCenter.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CPW221_PokemonAdoptionCenter.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Pokemon> pokemons { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)//FIGURE OUT HOW TO ADD PHOTOS OF EACH POKEMON TO DB AT SOME POINT
        {
            base.OnModelCreating(modelBuilder);
            //Details about all Pokemon at the center (Some have just recently been adopted but are still visible)
            modelBuilder.Entity<Pokemon>().HasData(
                new Pokemon {Id = 1, Name = "Molla", PokemonType = "Haunter", BattleType = "Poison/Ghost", Age = 307, Description = "Super sweet and a bit shy. Molla was found still in her ball after her owner had passed away, and now hopes to find a new playmate. She enjoys night walks and hide-and-seek", IsAvailable = true},

                new Pokemon {Id = 2, Name = "Kinito", PokemonType = "Paldean Wooper", BattleType = "Poison/Ground", Age = 4, Description = "Coming all the way from the Paldea region, Kinito has a naturally upbeat personality. Kinito enjoys swimming, splashing in puddles, and long afternoon naps.", IsAvailable = true},

                new Pokemon {Id = 3, Name = "Apollo", PokemonType = "Sylveon (Shiny)", BattleType = "Fairy", Age = 7, Description = "Apollo was dropped off at our center by his owner who was 'displeased' about Apollo's evolutionary choices. Nevertheless, Apollo continues to be incredibly affectionate and loving.", IsAvailable = true},

                new Pokemon {Id = 4, Name = "Captain Sushi", PokemonType = "Galarian Meowth", BattleType = "Steel", Age = 10, Description = "This Pokémon has been chosen! Best of luck, buddy!", IsAvailable = false },

                new Pokemon {Id = 5, Name = "Cleo", PokemonType = "Azumarill", BattleType = "Fairy/Water", Age = 8, Description = "Cleo is one of the most bubbly Pokémon we've ever met (both figuratively and literally) She was dropped off by her pervious owner who could no longer care for her.", IsAvailable = true}, 

                new Pokemon {Id = 6, Name = "Chompee", PokemonType = "Mareanie", BattleType = "Poison/Water", Age = 5, Description = "Found tangled in beach debris. When she refused to return to the sea, she was brought to us to find a home. Chompee is incredibly affectionate and adores physical contact. Just watch out for those spikes, as they may hurt.", IsAvailable = true},

                new Pokemon { Id = 7, Name = "Oliver", PokemonType = "Carnivine", BattleType = "Grass", Age = 13, Description = "This Pokémon has been chosen! Best of luck, buddy!", IsAvailable = false},

                new Pokemon { Id = 8, Name = "Lilo", PokemonType = "Flabébé", BattleType = "Grass", Age = 3, Description = "This Pokémon has been chosen! Best of luck, buddy!", IsAvailable = false},

                new Pokemon { Id = 9, Name = "Crystal", PokemonType = "Vaporeon", BattleType = "Water", Age = 9, Description = "Crystal spends most of his time in the pond behind our center, most often dozing or floating in circles. He will occasionally leave the pond to spend time with other Pokémon, but he most often prefers to loaf around. If you're looking for a good couch companion, this is your guy!", IsAvailable = true},

                new Pokemon { Id = 10, Name = "Theodore", PokemonType = "Phantump", BattleType = "Grass/Ghost", Age = 102, Description = "Found in an abandoned house, Theodore was brought into our care after it was determined he could not provide for himself in the wild. While he may seem incredibly shy and closed off at first, Theodore is actually very sweet once you get to know him.", IsAvailable = true},

                new Pokemon { Id = 11, Name = "Oakley", PokemonType = "Espurr", BattleType = "Psychic", Age = 4, Description = "Dropped off at our center as an egg, Oakley is fairly mild mannered and prefers to be alone most days. However, despite not wanting to play with the other Pokémon, Oakley will often be found close by to an employee, most often just watching as we go about our work.", IsAvailable = true},

                new Pokemon { Id = 12, Name = "Jade", PokemonType = "Kirlia", BattleType = "Psychic/Fairy", Age = 13, Description = "This Pokémon is currently still in rehabilitation. Please be patient with her!", IsAvailable = false}
                );

        }

    }

}
