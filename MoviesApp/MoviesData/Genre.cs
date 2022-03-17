using System;
using System.ComponentModel.DataAnnotations;

namespace MoviesData
{
    public class Genre
    {
        public string GenreId { get; set; }

        [Required(ErrorMessage = "Please enter a name.")]
        [StringLength(30)]
        public string Name { get; set; }
    }
}
