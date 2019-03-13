using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StuttgartCore.Pages.modul09
{
    public class apiClass
    {
    }
    public class Rootobject
    {
        public Class1[] Property1 { get; set; }
    }

    public class Class1
    {
        public int id { get; set; }
        public int kundenID { get; set; }
        public DateTime datum { get; set; }
        public string kopfText { get; set; }
        public float summe { get; set; }
        public object[] positionen { get; set; }
    }

}
