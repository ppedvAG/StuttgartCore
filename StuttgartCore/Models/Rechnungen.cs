using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace StuttgartCore.Models
{
    public class Rechnungen
    {
        public Rechnungen()
        {
            Positionen = new List<Positionen>();
        }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public int KundenID { get; set; }
       
        public DateTime Datum { get; set; }
        [Display(Name ="Firma", Prompt ="da gehört was rein")]
       
        public string KopfText { get; set; }
        public float Summe { get; set; }
        virtual public  List<Positionen> Positionen{ get; set; }
    }
}
