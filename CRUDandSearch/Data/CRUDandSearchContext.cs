using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CRUDandSearch.Models;

namespace CRUDandSearch.Data
{
    public class CRUDandSearchContext : DbContext
    {
        public CRUDandSearchContext (DbContextOptions<CRUDandSearchContext> options)
            : base(options)
        {
        }

        public DbSet<CRUDandSearch.Models.Movie> Movie { get; set; }
    }
}
