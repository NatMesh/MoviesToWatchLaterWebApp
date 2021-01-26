using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MovieWatchLaterWebApp.Model;

namespace MovieWatchLaterWebApp.Pages.MovieList
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _db;

        public IndexModel(ApplicationDbContext db)
        {
            //allows us to extract the ApplicationDbContext Object that is inside the dependency container and inject it into this page.
            _db = db;
        }

        //Create an IEnumerable to store our list of Movie records returned from our database.
        public IEnumerable<Movie> Movies { get; set; }

        public async Task OnGetAsync()
        {
            //This call to our database retrieves all the Movies from our database
            Movies = await _db.Movie.ToListAsync();
        }

        //Handles the delete request of a movie/show from our list 
        public async Task<IActionResult> OnPostDelete(int id)
        {
            var movie = await _db.Movie.FindAsync(id);
            if (movie == null)
            {
                return NotFound();
            }
            _db.Movie.Remove(movie);
            await _db.SaveChangesAsync();

            return RedirectToPage("Index");
        }
    }
}
