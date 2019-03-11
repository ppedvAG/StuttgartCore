using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace StuttgartCore.Pages.modul03
{
    public class calcModel : PageModel
    {
        public int Ergebnis { get; set; }
        public void OnGet()
        {
            int eins=Int32.Parse(   HttpContext.Request.Query["eins"]);
            int zwei = Int32.Parse(HttpContext.Request.Query["zwei"]);
            Ergebnis = eins + zwei;
        }
    }
}