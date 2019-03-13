using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using StuttgartCore.Models;

namespace StuttgartCore.Pages.modul07.Rechnung
{
    public class DetailsModel : PageModel
    {
        private readonly StuttgartCore.Models.RechnungContext _context;

        public DetailsModel(StuttgartCore.Models.RechnungContext context)
        {
            _context = context;
        }

        public Rechnungen Rechnungen { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Rechnungen = await _context.Rechnungens.Include(p=>p.Positionen)
                .FirstOrDefaultAsync(m => m.ID == id);

            if (Rechnungen == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
