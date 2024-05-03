using CPW221_PokemonAdoptionCenter.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CPW221_PokemonAdoptionCenter.Controllers
{
    public class PokeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PokeController(ApplicationDbContext context)
        {
            _context = context;
        }

        /// <summary>
        /// All Pokemon currently in the Adoption Center
        /// </summary>
        /// <returns>All Pokemon currently in the Adoption Center</returns>
        public async Task<IActionResult> AvailableMons() 
        { 
            //Get all Pokemon from the DB
            var adopt = _context.pokemons.ToList();

            //Show them on the page
            return View(adopt);
        }

        public async Task<IActionResult> AboutUs() 
        {

            return View();
        }

        public async Task<IActionResult> Survey()
        {

            return View();
        }

        [Authorize]
        public async Task<IActionResult> AdoptionSurvey()
        {

            return View();
        }
    }
}
