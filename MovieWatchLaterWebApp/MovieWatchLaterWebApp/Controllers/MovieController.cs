using Microsoft.AspNetCore.Mvc;
using MovieWatchLaterWebApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieWatchLaterWebApp.Controllers
{
    public class MovieController : Controller
    {
        private readonly ApplicationDbContext _db;


        public MovieController(ApplicationDbContext db)
        {
            _db = db;
        }

        [HttpGet]
        public IActionResult Index()
        {
            //This retrieves all of the Movies when we make this API call and it returns it in JSON format.
            return Json(new { data = _db.Movie.ToList() });
        }
    }
}
