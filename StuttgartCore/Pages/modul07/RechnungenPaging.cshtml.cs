using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace StuttgartCore.Pages.modul07
{
    public class RechnungenPagingModel : PageModel
    {
        public int Seite { get; set; }
        public void OnGet()
        {

        }
    }
}