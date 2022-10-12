using csharp_boolflix.Migrations;
using csharp_boolflix.Models;
using Microsoft.AspNetCore.Mvc;

namespace csharp_boolflix.Controllers
{
    public class GenreController : Controller
    {
        public IActionResult Index()
        {
            using (BoolflixContext context = new BoolflixContext())
            {
                List<Genre> genres = context.Genres.ToList();
                return View("Index", genres);
            }
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Genre formData)
        {
            if (!ModelState.IsValid)
            {
                return View("Create", formData);
            }

            using (BoolflixContext context = new BoolflixContext())
            {
                Genre genre = new Genre();
                genre.Name = formData.Name;

                context.Genres.Add(genre);

                context.SaveChanges();

                return RedirectToAction("Index");
            }
        }
    }
}
