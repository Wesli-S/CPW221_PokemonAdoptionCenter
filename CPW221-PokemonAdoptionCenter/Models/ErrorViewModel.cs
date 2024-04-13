using System.ComponentModel.DataAnnotations;

namespace CPW221_PokemonAdoptionCenter.Models
{
    public class ErrorViewModel
    {
        [Key]
        public string? RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
