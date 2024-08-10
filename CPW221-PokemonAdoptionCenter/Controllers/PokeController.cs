using CPW221_PokemonAdoptionCenter.Data;
using CPW221_PokemonAdoptionCenter.Models;
using Humanizer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.Elfie.Serialization;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Runtime.Intrinsics.X86;

namespace CPW221_PokemonAdoptionCenter.Controllers
{
    public class PokeController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IEmailProvider _emailProvider;
        private readonly UserManager<IdentityUser> _userManager;

        public PokeController(ApplicationDbContext context, IEmailProvider emailProvider, UserManager<IdentityUser> manager)
        {
            _context = context;
            _emailProvider = emailProvider;
            _userManager = manager;
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

        public async Task<IActionResult> YourMon()
        {
            //Only available pokemon will be displayed
            var pokemon = await _context.pokemons
                 .FromSqlRaw("SELECT TOP 1 * FROM pokemons WHERE IsAvailable = 1 ORDER BY NEWID()")
                     .FirstOrDefaultAsync();

            return View(pokemon);
        }

        public async Task<IActionResult> TYForSubmitting()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user != null)
            {
                var userEmail = user.Email;
                await _emailProvider.SendEmailAsync(userEmail, 
                    "silvergurlsmart@gmail.com", 
                    "Thank you so much for your application!",
                    "We're thrilled that you want to give one of our Pokémon a new home in you!" +
                    "Once we've completed going through your application, we'll be sure to contact you again to let you know if you qualify!" +
                    "Hope we get to see you real soon!", 
                    "<strong>" + "We're thrilled that you want to give one of our Pokémon a new home in you!" +
                    "Once we've completed going through your application, we'll be sure to contact you again to let you know if you qualify!" +
                    "Hope we get to see you real soon!" +
                    "-Yumi Smart (ICY Team)</strong>");
            }
            return View();
        }
    }
}
