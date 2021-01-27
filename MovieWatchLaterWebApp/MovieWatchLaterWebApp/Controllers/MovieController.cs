using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MovieWatchLaterWebApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieWatchLaterWebApp.Controllers
{
    [Route("api/Movie")]
    [ApiController]
    public class MovieController : Controller
    {
        private readonly ApplicationDbContext _db;


        public MovieController(ApplicationDbContext db)
        {
            _db = db;
        }

        [HttpGet]
        public async Task<IActionResult> IndexAsync()
        {
            //This retrieves all of the Movies when we make this API call and it returns it in JSON format.
            return Json(new { data = await _db.Movie.ToListAsync() });
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            var movieFromDb = await _db.Movie.FirstOrDefaultAsync(u => u.Id == id);
            if (movieFromDb == null)
            {
                return Json(new { success = false, message = "Error while Deleting" });
            }
            _db.Movie.Remove(movieFromDb);
            await _db.SaveChangesAsync();
            return Json(new { success = true, message = "Delete successful" });
        }
    }
}
