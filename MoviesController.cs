using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VideoRental.Models;
using VideoRental.ViewModels;

namespace VideoRental.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Shrek!" };
            //return Content("Hello World!");
            //return HttpNotFound(); //404 error
            //return new EmptyResult(); //nothing
            //return RedirectToAction("Index", "Home");
            //ViewData["Movie"] = movie;
            //var viewResult = new ViewResult();
            //viewResult.ViewData.Model

            var customers = new List<Customer>
            {
                new Customer{Name = "Customer1"},
                new Customer{Name = "Customer2"}
            };

            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };

            return View(viewModel);
        }

        public ActionResult Edit(int id)
        {
            return Content("id=" + id);
        }

        public ActionResult Index(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue)
                pageIndex = 1;
            if (String.IsNullOrWhiteSpace(sortBy))
                sortBy = "Name";
            return Content(String.Format("PageIndex={0}&sortBy={1}", pageIndex, sortBy));

        }
        
        [Route("movies/released/{year}/{month:regex(\\d{2}):range(1,12)}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);
        }
    }
}