using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MovieWatchLaterWebApp.Model;

namespace MovieWatchLaterWebApp.Pages.MovieList
{
    public class CreateModel : PageModel
    {
        public readonly ApplicationDbContext _db;

        public CreateModel(ApplicationDbContext db)
        {
            _db = db;
        }

        //This property sets it so on post the method OnPost() will assume we get a Movie object
        [BindProperty]
        public Movie Movie { get; set; }

        public void OnGet()
        {

        }

        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid)
            {
                //.Add preforms an insert into our Movie Table with the passed form data
                await _db.Movie.AddAsync(Movie);
                //.SaveChanges() persists the data to 
                await _db.SaveChangesAsync();
                //Takes us back to our List of media to watch later page
                return RedirectToPage("Index");
            }
            else
            {
                return Page();
            }
        }
    }
}
