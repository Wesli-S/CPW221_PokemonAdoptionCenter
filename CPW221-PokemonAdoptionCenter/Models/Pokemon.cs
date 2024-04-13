using System.ComponentModel.DataAnnotations;

namespace CPW221_PokemonAdoptionCenter.Models
{
    /// <summary>
    /// This class provides all info for Pokemon currently in the adoption center
    /// </summary>
    public class Pokemon
    {
        [Key]
        /// <summary>
        /// Id number of specified Pokemon
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// The Pokemon's name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The species of the specified Pokemon
        /// </summary>
        public string PokemonType { get; set; }

        /// <summary>
        /// The Pokemon's current age
        /// </summary>
        public int Age { get; set; }

        /// <summary>
        /// A brief description of the Pokemon and it's personality
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Lets the user know if this specific Pokemon has been set up for adoption already or not
        /// </summary>
        public bool IsAvailable { get; set; }


    }
}
