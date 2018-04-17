using RentalMovieMVC.Models;
using RentalMovieMVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RentalMovieMVC.Controllers
{
    public class MoviesController : Controller
    {
        //ActionResult Types: View(),PartialView(),Content(),Redirect(),RedirectToAction(),Json(),File(),HttpNotFound(),EmptyResult()
        //Action Parameters: 
        /*
         In the URL:            /movies/edit/1
         In the query string:   /movies/edit?id=1
         In the form data:      id=1
        */


        // GET: Movies
        public ActionResult Random()
        {
            var movie = new Movie { Id = 1, Name = "Movie 1"  };

            var customers = new List<Customer>
            {
                new Customer { Id = 1, Name = "Customer 1" },
                new Customer { Id = 1, Name = "Customer 2"  }
            };

            var viewmodel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };

            return View(viewmodel);
        }


          
        /*
         * http://localhost:50223/Movies/Edit/1
         * http://localhost:50223/Movies/Edit?id=1
         */
        public ActionResult Edit(int id)
        {
            return Content("id=" +id);
        }



        /* http://localhost:50223/Movies?pageIndex=10&sortBy=Petrov */
        public ActionResult Index(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue)
                pageIndex = 1;
            if (String.IsNullOrWhiteSpace(sortBy))
                sortBy = "Name";
            return Content(String.Format("pageIndex={0}&sortBy={1}", pageIndex, sortBy));
        }
    }
}