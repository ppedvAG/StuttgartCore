using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using StuttgartCore.Models;

namespace StuttgartCore.Pages.modul07.RechPos
{
    public class CreateModel : PageModel
    {
        private readonly StuttgartCore.Models.RechnungContext _context;
        public List<SelectListItem> RechnungIDs { get; set; }
        public CreateModel(StuttgartCore.Models.RechnungContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            var q = from r in _context.Rechnungens
                    select new SelectListItem
                    {
                        Text = r.KundenID.ToString(),
                        Value = r.KundenID.ToString()
                    };
            RechnungIDs = q.ToList();
            return Page();
        }

        [BindProperty]
        public Positionen Positionen { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Positionens.Add(Positionen);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}