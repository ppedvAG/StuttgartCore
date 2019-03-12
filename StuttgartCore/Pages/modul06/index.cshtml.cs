using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using StuttgartCore.Models;

namespace StuttgartCore.Pages.modul06
{
    public class indexModel : PageModel
    {
        private northwindContext db;
        public indexModel(northwindContext _db)
        {
            db = _db;

        }
        public void OnGet()
        {
            //var ef = new northwindContext();
            //var q = ef.Customers;
            //Dankeswort an DI
            var q = db.Customers;
        }
    }
}