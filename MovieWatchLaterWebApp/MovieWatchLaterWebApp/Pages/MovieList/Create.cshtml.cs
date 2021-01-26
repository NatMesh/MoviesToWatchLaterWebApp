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

        public Movie Movie { get; set; }

        public void OnGet()
        {

        }
    }
}
