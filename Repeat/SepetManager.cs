using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repeat
{
    class SepetManager
    {
        public void ekle(Urun Urun)
        {
            Console.WriteLine("Tebrikler Sepete Eklendi :  "+Urun.UrunAdi);
        }

        public void ekle2(string UrunAdi, string Aciklama,double Fiyati,int StokAdedi )
        {
            Console.WriteLine("Tebrikler Sepete Eklendi :  "+UrunAdi);
        }

    }
}
