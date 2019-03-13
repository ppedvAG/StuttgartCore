using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using StuttgartCore.Models;

namespace StuttgartCore.Pages.modul07.RechPos
{
    public class DeleteModel : PageModel
    {
        private readonly StuttgartCore.Models.RechnungContext _context;

        public DeleteModel(StuttgartCore.Models.RechnungContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Positionen Positionen { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Positionen = await _context.Positionens.FirstOrDefaultAsync(m => m.ID == id);

            if (Positionen == null)
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

            Positionen = await _context.Positionens.FindAsync(id);

            if (Positionen != null)
            {
                _context.Positionens.Remove(Positionen);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
