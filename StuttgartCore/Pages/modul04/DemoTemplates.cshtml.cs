using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace StuttgartCore.Pages.modul04
{
    public class DemoTemplatesModel : PageModel
    {
        public DateTime datum { get; set; }
        public void OnGet()
        {
            datum = DateTime.Now;
        }
    }
}