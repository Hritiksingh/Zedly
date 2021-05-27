using System.Collections.Generic;
using System.Web.Mvc;
using Zedly.Models;
using Zedly.ViewModels;

namespace Zedly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Moview
        public ActionResult Random()
        {
            var movie = new Movie() { Id = 1, Name = "3 Idiots" };
            var customers = new List<Customer>
            {
                new Customer { Id =1 , Name = "Ramesh"},
                new Customer {Id = 2, Name = "Suresh"}
            };

            var viewModel = new RandomMovieViewModel
            {
                movie = movie,
                customers = customers
            };
            
            return View(viewModel);
        }

        public ActionResult Index()
        {
            var movies = GetMovies();
            return View(movies);
        }

        public IEnumerable<Movie> GetMovies()
        {
            return new List<Movie>
            {
                new Movie { Id = 1, Name = "Shrek" },
                new Movie { Id = 2, Name = "Wall-e" }
            };
        }




        /*[Route("movies/released/{year}/{month:regex(\\d{2}):range(1,12)}")]
        public ActionResult ByReleaseYear(int year, int month)
        {
            return Content(year + " / " + month);
        }*/
    }
}