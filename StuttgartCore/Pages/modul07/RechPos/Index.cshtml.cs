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
    public class IndexModel : PageModel
    {
        private readonly StuttgartCore.Models.RechnungContext _context;

        public IndexModel(StuttgartCore.Models.RechnungContext context)
        {
            _context = context;
        }

        public IList<Positionen> Positionen { get;set; }

        public async Task OnGetAsync()
        {
            Positionen = await _context.Positionens.ToListAsync();
        }
    }
}
