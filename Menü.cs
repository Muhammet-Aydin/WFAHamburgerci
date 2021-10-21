using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFAHamburgerci
{
    public class Menü
    {
        public string MenüAdi { get; set; }
        public decimal Fiyat { get; set; }


        public override string ToString()
        {
            return MenüAdi + " Menü";
        }
    }
}
