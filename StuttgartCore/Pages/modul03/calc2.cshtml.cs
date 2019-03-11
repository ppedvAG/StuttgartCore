using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace StuttgartCore.Pages.modul03
{
    public class calc2Model : PageModel
    {
        public int Ergebnis { get; set; }
        public void OnPostMinus([FromForm] int eins, [FromForm] int zwei)
        {
           
                Ergebnis = eins - zwei;
            


        }
        public void OnPostPlus([FromForm] int eins, [FromForm] int zwei)
        {
          
                Ergebnis = eins + zwei;
          
        }
    }
}