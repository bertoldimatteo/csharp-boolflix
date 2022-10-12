using Microsoft.AspNetCore.Mvc;

namespace csharp_boolflix.Controllers
{
    public class TvSerieController : Controller
    {
        public IActionResult Index()
        {
            return View("Index");
        }
    }
}
