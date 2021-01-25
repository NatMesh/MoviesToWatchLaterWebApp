using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieWatchLaterWebApp.Model
{
    //A DbContext instance represents a session with the database and can be used to query and save instances of your entities.
    //make our class inherit form DbContext which is a class built in EntityFrameworkCore
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Movie> Movie { get; set; }
    }
}
