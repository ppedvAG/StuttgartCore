using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace StuttgartCore.Pages.modul07
{
    public class calcModel : PageModel
    {
        public int Ergebnis { get; set; }
        [BindProperty]
        public rechner myrechner { get; set; }
        public void OnPostMinus()
        {

            Ergebnis = myrechner.eins - myrechner.zwei;



        }
        public void OnPostPlus()
        {

            Ergebnis = myrechner.eins + myrechner.zwei;

        }
    }
    public class rechner
    {
        public int eins { get; set; }
      
        public int zwei { get; set; }
    }
    
}