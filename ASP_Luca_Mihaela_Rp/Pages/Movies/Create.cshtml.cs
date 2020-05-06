using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ASP_Luca_Mihaela_Rp.Data;
using ASP_Luca_Mihaela_Rp.Models;

namespace ASP_Luca_Mihaela_Rp
{
    public class CreateModel : PageModel
    {
        private readonly ASP_Luca_Mihaela_Rp.Data.ASP_Luca_Mihaela_RpContext _context;

        public CreateModel(ASP_Luca_Mihaela_Rp.Data.ASP_Luca_Mihaela_RpContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Movie Movie { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Movie.Add(Movie);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
