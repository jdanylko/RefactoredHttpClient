using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using UsingHttpClientExample.ApiCollection.RickAndMorty;

namespace UsingHttpClientExample.Controllers
{
    public class RickAndMortyController : Controller
    {
        private readonly IRickAndMortyCharacterApi _api;

        public RickAndMortyController(IRickAndMortyCharacterApi api)
        {
            _api = api;
        }

        public async Task<IActionResult> Index()
        {
            var characters = await _api.GetCharacters();

            return View(characters);
        }
    }
}
