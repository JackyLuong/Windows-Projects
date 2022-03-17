using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesData
{
    /// <summary>
    /// Methods for working with genre table
    /// </summary>
    public class GenreManager
    {
        public static List<Genre> GetGenres()
        {
            MovieContext db = new MovieContext();
            return db.Genres.ToList();
        }

        // What if the genre calss was a lot of properties
        /// <summary>
        /// Retrieves list of only ids and names
        /// </summary>
        /// <returns>List of anonymous type</returns>
        public static IList GetGenresAsKeyValuePairs()
        {
            MovieContext db = new MovieContext();
            var types = db.Genres.OrderBy(g => g.Name)
                .Select(g => new { Value = g.GenreId, Text = g.Name }).ToList();
            return types;
        }
        /// <summary>
        /// Find Genre with given id
        /// </summary>
        /// <param name="id">Genre id</param>
        /// <returns>Genre with id or null if not found</returns>
        public static Genre Find(string id)
        {
            MovieContext db = new MovieContext();
            return db.Genres.Find(id);
        }
    }
}
