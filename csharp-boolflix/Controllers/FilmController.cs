using csharp_boolflix.Migrations;
using csharp_boolflix.Models;
using Microsoft.AspNetCore.Mvc;

namespace csharp_boolflix.Controllers
{
    public class FilmController : Controller
    {
        public IActionResult Index()
        {
            using (BoolflixContext context = new BoolflixContext())
            {
                List<Film> films = context.Films.ToList();
                return View("Index", films);
            }
        }


        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Film formData)
        {
            if (!ModelState.IsValid)
            {
                return View("Create", formData);
            }

            using (BoolflixContext context = new BoolflixContext())
            {
                Film film = new Film();
                film.Name = formData.Name;
                film.Age = formData.Age;
                film.Image = formData.Image;
                film.Duration = formData.Duration;

                context.Films.Add(film);

                context.SaveChanges();

                return RedirectToAction("Index");
            }
        }
    }
}
