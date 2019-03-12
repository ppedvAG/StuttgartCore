﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace StuttgartCore.Pages.modul05
{
    public class ExportExcelModel : PageModel
    {
        public void OnGet()
        {
            HttpContext.Response.ContentType = "application/vnd.ms-excel";
            
        }
    }
}