using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using StuttgartCore.Pages.modul02;

namespace StuttgartCore.Pages.modul03
{
   
    public class hannesfatModel : PageModel
    {
        public int Feld1 { get; set; }
        public HannesKlasse MyProperty { get; set; }
        public void OnGet([FromServices] HannesKlasse hk)
        {
            hk.HannesProperty++;
            Feld1 = 10;
        }
    }
}