using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace StuttgartCore.Pages.modul05
{
    public class tmpDataModel : PageModel
    {
        public string Wert { get; set; }
        public void OnGet()
        {

            if (TempData.Peek("hannes") != null)
            {


                Wert = TempData["hannes"].ToString();

            }

        }
        public void OnPost([FromForm] string wert)
        {

            TempData["hannes"] = wert;
        }
    }
}