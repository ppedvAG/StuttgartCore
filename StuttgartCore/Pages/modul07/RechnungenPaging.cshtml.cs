using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace StuttgartCore.Pages.modul07
{
    [IgnoreAntiforgeryToken(Order=1001)]
    public class RechnungenPagingModel : PageModel
    {
        public int Seite { get; set; }
        public void OnGet()
        {

        }
        public ViewComponentResult OnPost()
        {
            Seite++;
            return ViewComponent("RechnungPaged", new { page = Seite });


        }
    }
}