using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Movies_MVC.Models;

namespace Movies_MVC.Data
{
    public class Movies_MVCContext : DbContext
    {
        public Movies_MVCContext (DbContextOptions<Movies_MVCContext> options)
            : base(options)
        {
        }

        public DbSet<Movies_MVC.Models.Movie> Movie { get; set; }
    }
}
