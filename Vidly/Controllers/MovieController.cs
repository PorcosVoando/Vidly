using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;


namespace Vidly.Controllers
{
    public class MovieController : Controller
    {
        // GET: Movie

        public ActionResult Random()
        {
           var movie = new Movie() {Name = "Shrek!"};
           var customers = new List<Customer>
           {
               new Customer {Name = "Costumer 01"},
               new Customer {Name = "Costumer 02"}
           };
           var viewModel = new RandomMovieViewModel
           {
               Movie = movie,
               Customer = customers
           };
           return View(viewModel);
        }
        [Route("movie/released/{year:regex(\\d{4}):range(2000,2019)}/{month:regex(\\d{2}):range(1, 12)}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);
        }

        public ActionResult Edit(int id)
        {
            return Content("id=" + id);
        }

        public ActionResult Index(int? pageIndex, string sortBy)
        {
            var movies = new List<Movie>
            {
                new Movie{Id= 1, Name = "Beowulf"},
                new Movie{Id= 2, Name = "Harry Potter"},
                new Movie{Id= 3, Name = "O Chamado"},
                new Movie{Id= 4, Name = "Avatar"}
            };
            
            return View(movies);
        }
    }
}