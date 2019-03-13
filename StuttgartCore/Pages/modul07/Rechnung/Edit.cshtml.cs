using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using StuttgartCore.Models;

namespace StuttgartCore.Pages.modul07.Rechnung
{
    public class EditModel : PageModel
    {
        private readonly StuttgartCore.Models.RechnungContext _context;

        public EditModel(StuttgartCore.Models.RechnungContext context)
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

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Rechnungen).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RechnungenExists(Rechnungen.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool RechnungenExists(int id)
        {
            return _context.Rechnungens.Any(e => e.ID == id);
        }
    }
}
