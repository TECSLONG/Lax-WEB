using Opgave_5___2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Opgave_5___2.Controllers
{
    public class MovieController : Controller
    {

        // GET: Movie
        public ActionResult Movies()
        {
            SQLToolbox.GetMovieData(); // imports data from database
            ViewBag.MovieListClass = MovieListClass.MovieList; // attaches the MovieList to the View
            return View();
        }

        // GET: About
        public ActionResult About()
        {
            ViewBag.Message = "This is the moviepage"; // temp message sent to the View
            return View();
        }
    }
}