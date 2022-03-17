using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace MoviesData
{
    //Methods for working with Movie table
    public static class MovieManager
    {
        public static List<Movie> GetMovies()
        {
            MovieContext db = new MovieContext();
            return db.Movies.Include(m=>m.Genre).ToList();
        }
        /// <summary>
        /// Adds movie
        /// </summary>
        /// <param name="movie">movie to add</param>
        public static void AddMovie(Movie movie)
        {
            MovieContext db = new MovieContext();
            db.Movies.Add(movie);
            db.SaveChanges();
        }
        /// <summary>
        /// Update selected movie information
        /// </summary>
        /// <param name="movieID"> Primary key of the movie that is being updated</param>
        /// <param name="newMovie"> new movie information</param>
        public static void UpdateMovie(int movieID, Movie newMovie)
        {
            MovieContext db = new MovieContext();
            Movie oldMovie = db.Movies.Find(movieID);
            oldMovie.Name = newMovie.Name;
            oldMovie.Year = newMovie.Year;
            oldMovie.Rating = newMovie.Rating;
            oldMovie.GenreId = newMovie.GenreId;
            db.SaveChanges();
        }
        /// <summary>
        /// Delete selecte moive
        /// </summary>
        /// <param name="movieID">ID of the movie to delete</param>
        public static void DeleteMovie(int movieID)
        {
            MovieContext db = new MovieContext();
            Movie selectedMovie = db.Movies.Find(movieID);
            db.Movies.Remove(selectedMovie);
            db.SaveChanges();
        }
        /// <summary>
        /// Get movie object based on given movie id
        /// </summary>
        /// <param name="movieId">Id of the selected movie</param>
        /// <returns> selected movie or unknown if not found</returns>
        public static Movie getSelectedMovieById(int movieId)
        {
            MovieContext db = new MovieContext();
            Movie movie = db.Movies.Include(m => m.Genre).Where(m => m.MovieId == movieId).SingleOrDefault();
            return movie;
        }
        /// <summary>
        /// Get movies of given genre
        /// </summary>
        /// <param name="genreId"> id of the genre</param>
        /// <returns>List of movies with that genre</returns>
        public static List<Movie> GetMoviesByGenre(string genreId)
        {
            MovieContext db = new MovieContext();
            return db.Movies.Where(m => m.GenreId == genreId).ToList();
        }
    }
}
