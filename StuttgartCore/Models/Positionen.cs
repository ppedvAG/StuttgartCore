using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace StuttgartCore.Models
{
    public class Positionen
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public int RechnungenID { get; set; }
        public int Anzahl { get; set; }
        public string Text { get; set; }
        [Required(ErrorMessage ="da muss was rein")]
        [DataType(DataType.Text)]
        public float Preis { get; set; }
    }
}
