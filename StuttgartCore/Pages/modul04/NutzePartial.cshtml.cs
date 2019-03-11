using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace StuttgartCore.Pages.modul04
{
    public class NutzePartialModel : PageModel
    {
        public void OnGet()
        {

        }
        public PartialViewResult OnPost()
        {

            return Partial("_Zeit");
        }
        public PartialViewResult OnGetLade()
        {

            return Partial("_Zeit");
        }
    }
}