using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tekrar
{
    class SepetManager
    {

        public void Ekle(Urun urun)
        {
            Console.WriteLine("Tebrikler Sepete Eklendi  :  " + urun.UrunAdi);
        }

        public void Ekle2(string UrunAdi, string Aciklama, double Fiyatı, int StokAdedi)
        {
            Console.WriteLine("Tebrikler Sepete Eklendi  :   " + UrunAdi);
        }

    }
}
