using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Personel
    {
        Random r = new Random();
        public int Yas { get; set; }
        public decimal Maas { get; set; }
        public Personel()
        {
            Yas = r.Next(25,50);
            Maas = r.Next(2100,10000);
        }
       
    }
}
