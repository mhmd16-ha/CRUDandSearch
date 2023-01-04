using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CRUDandSearch.Data;
using CRUDandSearch.Models;

namespace CRUDandSearch.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly CRUDandSearch.Data.CRUDandSearchContext _context;

        public IndexModel(CRUDandSearch.Data.CRUDandSearchContext context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; }

        [BindProperty(SupportsGet =true)]
        public string SearchString { get; set; }
        public async Task OnGetAsync()
        {
            var movies = from m in _context.Movie select m;
            if (!string.IsNullOrEmpty(SearchString))
            {
                movies = movies.Where(x => x.Title.Contains(SearchString));
            }
            Movie = await movies.ToListAsync();
        }
    }
}
