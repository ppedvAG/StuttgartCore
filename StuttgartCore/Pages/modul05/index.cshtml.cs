using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http; //SetString
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace StuttgartCore.Pages.modul05
{
    public class indexModel : PageModel
    {
        public string Wert { get; set; }
        public void OnGet()
        {
            Wert = HttpContext.Session.GetString("wert");
            
        }
        public void OnPost([FromForm] string wert)
        {
            HttpContext.Session.SetString("wert", wert);
            Wert = wert;
        }
    }
}