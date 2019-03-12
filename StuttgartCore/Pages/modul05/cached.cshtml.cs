using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace StuttgartCore.Pages.modul05
{
    [ResponseCache(Duration =300,Location =ResponseCacheLocation.Any)]
    public class cachedModel : PageModel
    {
      
        public void OnGet()
        {

        }

    }
}