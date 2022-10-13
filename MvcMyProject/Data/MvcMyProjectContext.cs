using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcMyProject.Models;

namespace MvcMyProject.Data
{
    public class MvcMyProjectContext : DbContext
    {
        public MvcMyProjectContext (DbContextOptions<MvcMyProjectContext> options)
            : base(options)
        {
        }

        public DbSet<MvcMyProject.Models.Movie> Movie { get; set; }
    }
}
