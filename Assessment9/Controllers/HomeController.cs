using Assessment9.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Assessment9.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public async Task<IActionResult> BookDetails(int id)
        {
            Book book = await DAL.FindBook(id);
            return View(book);
        }
        public async Task<IActionResult> HouseDetails(int id)
        {
            House house = await DAL.FindHouse(id);
            foreach (string characterUrl in house.swornMembers)
            {
                Character character = await DAL.FindCharacter(characterUrl);
                house.character.Add(character);
            }
            if(house.currentLord.Length > 0)
            {
                house.currentLordChar = await DAL.FindCharacter(house.currentLord);
            }
            return View(house);
        }
        public async Task<IActionResult> CharDetails(string url)
        {
            Character character = await DAL.FindCharacter(url);
            return View(character);
        }
        // if needed
        public async Task<IActionResult> BaseHome()
        {
            List<int> ids = new List<int>()
            {
                2,
                823,
                688,
                400,
                583
            };

            List<Character> characters = new List<Character>();
            foreach (int id in ids)
            {
                characters.Add(await DAL.GetSpecificCharacter(id));
            }
            return View(characters);
        }

    }
}