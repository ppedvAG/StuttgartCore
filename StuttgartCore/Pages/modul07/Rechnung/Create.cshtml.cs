using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using StuttgartCore.Models;

namespace StuttgartCore.Pages.modul07.Rechnung
{
    public class CreateModel : PageModel
    {
        private readonly StuttgartCore.Models.RechnungContext _context;

        public CreateModel(StuttgartCore.Models.RechnungContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Rechnungen Rechnungen { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Rechnungens.Add(Rechnungen);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}