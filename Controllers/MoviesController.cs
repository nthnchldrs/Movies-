using Movies_.Models;
using System.Web.Mvc;

namespace Movies_.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Star Wars: The Empire Strikes Back", Id = 23165497 };

            return View(movie);
        }
    }
}