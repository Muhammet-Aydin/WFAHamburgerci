using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFAHamburgerci
{
    public class Sipariş
    {
        public Menü SecilenMenü { get; set; }
        public Boyut Boyut { get; set; }

        public List<Ekstra> EkstraMalzemesi { get; set; }

        public int Adet { get; set; }//Sipariş menu Adeti

        public decimal ToplamTutar { get; set; }//Sipariş toplam

        public  void    Hesapla()
        {
            ToplamTutar = 0;

             ToplamTutar += SecilenMenü.Fiyat;


            switch (Boyut)
            {

                case Boyut.Orta:ToplamTutar += ToplamTutar * 0.10m; break;
                case Boyut.Büyük:ToplamTutar += ToplamTutar * 0.20m; break;
            }

            ToplamTutar = ToplamTutar * Adet;

            foreach (Ekstra item in EkstraMalzemesi)//var bırakılmaz cunku gelen objeyı tekrar ekstraya cast etmek gerekır.
            {
                ToplamTutar += item.EkstraFiyat;
            }
           
        }
        public override string ToString()
        {
            if (EkstraMalzemesi.Count<1)
            {
                return string.Format("{0} Menü,X{1} Adet,{2} Boy,Toplam:{3}",SecilenMenü.MenüAdi,Adet,Boyut.ToString(),ToplamTutar.ToString("C2"));

            }
            else
            {
                string exMalzemeler = null;
                foreach (Ekstra item in EkstraMalzemesi)
                {
                    exMalzemeler += item.EkstraAdi + ",";
                    exMalzemeler = exMalzemeler.Trim(',');

                }
                 return string.Format("{0} Menu, X {1} Adet:,{2} Boy,({3}) Toplam:{4}",SecilenMenü.MenüAdi,Adet,Boyut.ToString(),exMalzemeler,ToplamTutar.ToString("C2"));
            }
     
        }
    }
}
