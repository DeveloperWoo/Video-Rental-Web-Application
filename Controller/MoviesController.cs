using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VideoRental.Models;
using VideoRental.ViewModels;

namespace VideoRental.Controllers
{
    public class MoviesController : Controller
    {
        //Access Database
        private ApplicationDbContext _context;
        public MoviesController()
        {
            _context = new ApplicationDbContext();
        }

        //override Dispose() of base Controller class
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ActionResult Index()

        {
            var movies = _context.Movies.Include(m => m.Genre).ToList();
            return View(movies);
        }

        // GET: Movies/Random
        public ActionResult Random()
        {
            var movies = new List<Movie>
            {
                new Movie{Name = "Shrek"},
                new Movie{Name = "Wall-e"}
            };

            //add two customers
            var customers = new List<Customer>
            {
                new Customer{Name = "Hyunju"},
                new Customer{Name = "MJ"}
            };

            var viewModel = new RandomMovieViewModel
            {
                Movies = movies,
                Customers = customers
            };

            return View(viewModel);
            //return Content("Hello World!");
            //return HttpNotFound(); //404 error
            //return new EmptyResult(); //nothing in the response
            //return RedirectToAction("Index", "Home");
            //ViewData["Movie"] = movie;
            //var viewResult = new ViewResult();
            //viewResult.ViewData.Model
        }

        public ActionResult Edit(int id)
        {
            return Content("id=" + id);
            /*
             * in the URL: movies/edit/1
             * in the query string: movies/edit?id=1
             * in the form data: id=1
             */
        }


        [Route("movies/released/{year}/{month:regex(\\d{2}):range(1,12)}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);
        }

        public ActionResult Details(int id)
        {
            var movie = _context.Movies.Include(m => m.Genre).SingleOrDefault(m => m.Id == id);

            if (movie == null)
                return HttpNotFound();

            return View(movie);
        }
    }
}