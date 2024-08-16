using CPW221_PokemonAdoptionCenter.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CPW221_PokemonAdoptionCenter.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IEmailProvider _emailProvider;
        private readonly UserManager<IdentityUser> _userManager;
        

        public HomeController(ILogger<HomeController> logger, IEmailProvider emailProvider, UserManager<IdentityUser> manager)
        {
            _logger = logger;
            _emailProvider = emailProvider;
            _userManager = manager;
        }

        public IActionResult Index()
        {
            return View();
        }

        [Authorize]//The user won't be able to view this page without an account
        public IActionResult Volunteer()
        {
            return View();
        }

        public async Task<IActionResult> VolunteerTY() {
            var user = await _userManager.GetUserAsync(User);
            if (user != null)
            {
                var userEmail = user.Email;
                await _emailProvider.SendEmailAsync(userEmail,
                    "silvergurlsmart@gmail.com",
                    string.Empty,//data is in the email template
                    string.Empty,
                    string.Empty,
                    "Views/Home/VolunteerTY");
            }
            return View();
        }

        //User MUST make an account before applying to volunteer/adopt

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


    }
}
