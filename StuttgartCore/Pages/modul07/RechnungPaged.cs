using Microsoft.AspNetCore.Mvc;
using StuttgartCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StuttgartCore.Pages.modul07
{
    public class RechnungPaged:ViewComponent
    {
        private RechnungContext _db;
        public RechnungPaged(RechnungContext db)
        {
            _db = db;
        }
        public IViewComponentResult Invoke(int page=0)
        {
            List<Rechnungen> model = _db.Rechnungens.Skip(page * 3).Take(3).ToList();
            return View(model); //default.cshtml
        }
    }
}
