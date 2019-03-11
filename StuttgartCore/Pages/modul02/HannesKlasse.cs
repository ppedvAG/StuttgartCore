using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StuttgartCore.Pages.modul02
{
    public class HannesKlasse
    {
        public int HannesProperty { get; set; }
    }
    class VerwendeHannesKlasse
    {
       

        public VerwendeHannesKlasse(HannesKlasse hk)
        {
            hk.HannesProperty = 1;

        }
    }
    class MyClass
    {
        public MyClass()
        {
            //var x = new VerwendeHannesKlasse();
        }

    }
}
