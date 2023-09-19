using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CaesarMovie.Models;

namespace CaesarMovie.Data
{
    public class CaesarMovieContext : DbContext
    {
        public CaesarMovieContext(DbContextOptions<CaesarMovieContext> options)
            : base(options)
        {
        }

        public DbSet<CaesarMovie.Models.Movie> Movie { get; set; } = default!;
    }
}
