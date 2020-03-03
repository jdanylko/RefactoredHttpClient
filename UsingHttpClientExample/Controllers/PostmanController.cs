using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using UsingHttpClientExample.ApiCollection._postmanEcho;

namespace UsingHttpClientExample.Controllers
{
    public class PostmanController : Controller
    {
        private readonly IPostmanEchoApi _api;

        public PostmanController(IPostmanEchoApi postmanApi)
        {
            _api = postmanApi;
        }

        public async Task<IActionResult> Index()
        {
            var viewModel = await _api.GetEchoAsync("bar");

            return View(viewModel);
        }
    }
}
