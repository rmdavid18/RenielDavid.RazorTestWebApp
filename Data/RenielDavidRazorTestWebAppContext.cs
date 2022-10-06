using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RenielDavid.RazorTestWebApp.Models;

namespace RenielDavid.RazorTestWebApp.Data
{
    public class RenielDavidRazorTestWebAppContext : DbContext
    {
        public RenielDavidRazorTestWebAppContext (DbContextOptions<RenielDavidRazorTestWebAppContext> options)
            : base(options)
        {
        }

        public DbSet<RenielDavid.RazorTestWebApp.Models.Movie> Movie { get; set; } = default!;
    }
}
