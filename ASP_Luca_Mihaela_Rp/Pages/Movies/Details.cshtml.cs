﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ASP_Luca_Mihaela_Rp.Data;
using ASP_Luca_Mihaela_Rp.Models;

namespace ASP_Luca_Mihaela_Rp
{
    public class DetailsModel : PageModel
    {
        private readonly ASP_Luca_Mihaela_Rp.Data.ASP_Luca_Mihaela_RpContext _context;

        public DetailsModel(ASP_Luca_Mihaela_Rp.Data.ASP_Luca_Mihaela_RpContext context)
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

            Movie = await _context.Movie.FirstOrDefaultAsync(m => m.ID == id);

            if (Movie == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
