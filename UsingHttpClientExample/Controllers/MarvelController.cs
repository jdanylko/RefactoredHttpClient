using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using UsingHttpClientExample.ApiCollection.Marvel;

namespace UsingHttpClientExample.Controllers
{
    public class MarvelController : Controller
    {
        private readonly IMarvelComicApi _api;

        public MarvelController(IMarvelComicApi api)
        {
            _api = api;
        }

        public async Task<IActionResult> Index()
        {
            // Marvel
            var comics = await _api.GetComicsByTitle("Wolverine");

            return View(comics);
        }
    }
}
