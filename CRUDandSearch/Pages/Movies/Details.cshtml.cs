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
    public class DetailsModel : PageModel
    {
        private readonly CRUDandSearch.Data.CRUDandSearchContext _context;

        public DetailsModel(CRUDandSearch.Data.CRUDandSearchContext context)
        {
            _context = context;
        }

        public Movie Movie { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Movie = await _context.Movie.FirstOrDefaultAsync(m => m.Id == id);

            if (Movie == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
