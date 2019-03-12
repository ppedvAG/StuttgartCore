using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace StuttgartCore.Pages.modul05
{
    public class DateiUploadModel : PageModel
    {
        public void OnGet()
        {

        }
        public void OnPost(IFormFile datei)
        {
            var pfad = @"C:\aspnetcore\training\StuttgartCore\StuttgartCore\wwwroot\app_data";
            pfad = Path.Combine(pfad, Path.GetFileName(datei.FileName));
            using (var fs = new FileStream(pfad, FileMode.Create))
            {
                datei.CopyTo(fs);
            }


        }
    }
}