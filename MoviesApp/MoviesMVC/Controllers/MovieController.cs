using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MoviesData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesMVC.Controllers
{
    public class MovieController : Controller
    {
        // GET: MovieController
        public ActionResult Index()
        {
            List<Movie> movies = null;
            try
            {
                movies = MovieManager.GetMovies();
            }
            catch
            {
                TempData["Message"] = "Database connection problem. Try again later.";
                TempData["IsError"] = true;
            }
            return View(movies);
        }

        // GET: MovieController/Details/5
        public ActionResult Details(int id)
        {
            Movie movie = MovieManager.getSelectedMovieById(id);
            return View(movie);
        }

        // GET: MovieController/Create
        public ActionResult Create()
        {
            try
            {
                //prepare list of genres for the drop down list and pass through the view bag
                var types = GenreManager.GetGenresAsKeyValuePairs();
                SelectList list = new SelectList(types, "Value", "Text");
                ViewBag.Genres = list;

                //return View();// by default it returns a view thats named the same as the method
                return View("Edit", new Movie()); // MovieId is 0
            }
            catch(Exception)
            {
                TempData["Message"] = "Database connection problem. Try again later.";
                TempData["IsError"] = true;
                return RedirectToAction("Index");
            }
        }

        // POST: MovieController/Create
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create(Movie movie) // what is collected on the form is Movie data
        //{
        //    try
        //    {
        //        MovieManager.AddMovie(movie);
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        // GET: MovieController/Edit/5
        public ActionResult Edit(int id)
        {
            try
            {
                //prepare list of genres for the drop down list and pass through the view bag
                var types = GenreManager.GetGenresAsKeyValuePairs();
                SelectList list = new SelectList(types, "Value", "Text");
                ViewBag.Genres = list;

                Movie movie = MovieManager.getSelectedMovieById(id);
                return View(movie);
            }
            catch(Exception)
            {
                TempData["Message"] = "Database connection problem. Try again later.";
                TempData["IsError"] = true;
                return RedirectToAction("Index");
            }
        }

        // POST: MovieController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Movie movie) // form collection is a movie
        {
            try
            {
                if (id == 0) // create
                {
                    MovieManager.AddMovie(movie);
                    TempData["Message"] = $"{movie.Name} sucessfully added";
                    TempData["IsError"] = false;
                }
                else // Update
                {
                    MovieManager.UpdateMovie(id, movie);
                    TempData["Message"] = $"{movie.Name} sucessfully updated";
                    TempData["IsError"] = false;
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                TempData["Message"] = "Database connection problem. Try again later.";
                TempData["IsError"] = true;
                return RedirectToAction(nameof(Index));
            }
        }

        // GET: MovieController/Delete/5
        public ActionResult Delete(int id)
        {
            try
            {
                Movie movie = MovieManager.getSelectedMovieById(id);
                return View(movie);
            }
            catch
            {
                TempData["Message"] = "Database connection problem. Try again later.";
                TempData["IsError"] = true;
                return RedirectToAction("Index");
            }
        }

        // POST: MovieController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Movie movie)
        {
            try
            {
                Movie oldMovie = MovieManager.getSelectedMovieById(id);
                MovieManager.DeleteMovie(id);
                TempData["Message"] = $"{oldMovie.Name} sucessfully updated";
                TempData["IsError"] = false;
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                TempData["Message"] = "Database connection problem. Try again later.";
                TempData["IsError"] = true;
                return RedirectToAction("Index");
            }
        }
    }
}
