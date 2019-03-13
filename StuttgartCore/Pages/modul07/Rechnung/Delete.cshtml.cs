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
    public class DeleteModel : PageModel
    {
        private readonly StuttgartCore.Models.RechnungContext _context;

        public DeleteModel(StuttgartCore.Models.RechnungContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Rechnungen Rechnungen { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Rechnungen = await _context.Rechnungens.FirstOrDefaultAsync(m => m.ID == id);

            if (Rechnungen == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Rechnungen = await _context.Rechnungens.FindAsync(id);

            if (Rechnungen != null)
            {
                _context.Rechnungens.Remove(Rechnungen);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
