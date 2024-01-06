using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebDotnetMVC.Models;

namespace WebDotnetMVC.Data
{
    public class WebDotnetMVCContext : DbContext
    {
        public WebDotnetMVCContext (DbContextOptions<WebDotnetMVCContext> options)
            : base(options)
        {
        }

        public DbSet<WebDotnetMVC.Models.Movie> Movie { get; set; } = default!;
    }
}
