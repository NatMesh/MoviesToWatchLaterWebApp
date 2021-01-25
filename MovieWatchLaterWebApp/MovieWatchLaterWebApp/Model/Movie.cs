using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MovieWatchLaterWebApp.Model
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }

        //The name of the show, movie, or anime
        [Required]
        public string Name { get; set; }

        //The genre either action, horror, romance, comedy, etc.
        public string Genre { get; set; }

        //Whether the item is a movie, tv show or anime
        public string Medium { get; set; }
    }
}
