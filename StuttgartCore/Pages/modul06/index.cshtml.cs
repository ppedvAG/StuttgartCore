using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using StuttgartCore.Models;

namespace StuttgartCore.Pages.modul06
{
    public class indexModel : PageModel
    {
        private RechnungContext db;
        public indexModel(RechnungContext _db)
        {
            db = _db;

        }
        public void OnGet()
        {
            //var ef = new northwindContext();
            //var q = ef.Customers;
            //Dankeswort an DI
            var q = db.Rechnungens.ToList();
         
            var r = new Rechnungen() { Datum = DateTime.Now, KopfText = "code generiert", KundenID = 1, Summe = 20 };
            r.Positionen.Add(new Positionen { Anzahl = 2, Preis = 3 });
            r.Positionen.Add(new Positionen { Anzahl = 10, Preis = 33 });
            r.Positionen.Add(new Positionen { Anzahl = 20, Preis = 3333 });

            db.Rechnungens.Add(r);
            db.SaveChanges();

            var anzahl = db.Rechnungens.Where(x => x.Summe > 10).Skip(10).Take(10).Count();

            var abfrage = from x in db.Positionens
                          where x.Anzahl > 1
                          orderby x.RechnungenID
                          select new Positionen {Text= x.Text };
            //   "Select id from positionen where anzahl>1 "
            var t = db.Rechnungens.FromSql("Select * from rechnungen");


            var d = db.Rechnungens.Find(1);
            d.Summe = 1000;
            db.Rechnungens.Remove(d);
            db.SaveChanges();

        }
    }
}