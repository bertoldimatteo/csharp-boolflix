using Microsoft.AspNetCore.Mvc;

namespace csharp_boolflix.Controllers
{
    public class BoolflixController : Controller
    {
        public IActionResult Index()
        {
            return View("Index");
        }
    }
}
