using CPW221_PokemonAdoptionCenter.Data;
using Microsoft.AspNetCore.Mvc;

namespace CPW221_PokemonAdoptionCenter.Controllers
{
    public class PokeController : Controller
    {
        private readonly ApplicationDbContext _context;

        /// <summary>
        /// 
        /// </summary>
        /// <returns>All Pokemon currently in the Adoption Center</returns>
        public async Task<IActionResult> AvailableMons() 
        { 
            //Get all Pokemon from the DB
            /*List<Pokemon> adopt = await (from pokemon in _context.Pokemon
             *                          select pokemon).ToListAsync(); //FINISH LATER*/

            //Show them on the page
            return View(/*pokemon*/);
        }

        public async Task<IActionResult> AboutUs() 
        {

            return View();
        }
    }
}
