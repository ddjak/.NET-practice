﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Shrek"};

            var customers = new List<Customer>
            {
                new Customer {Name = "Customer 1"},
                new Customer {Name = "Customer 2"}
            };

            var ViewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };

            return View(ViewModel);
        }

        // movies/edit/1 or movies/edit/id=1 or movies/edit?id=1
        public ActionResult Edit(int id)
        {
            return Content("id=" + id);
        }

        // movies
        public ViewResult Index()
        {
            var movies = GetMovies();

            return View(movies);
            
        }

        private IEnumerable<Movie> GetMovies()
        {
            return new List<Movie>
            {
                new Movie {id = 1, Name = "Shrek"},
                new Movie {id = 2, Name = "Wall-E"}
            };
        }

        //[Route("movies/released/{year}/{month:regex(\\d{4}):range(1,12)}")]

        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);
        }
    }
}