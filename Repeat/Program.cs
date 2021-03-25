using System;

namespace Repeat
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "Karpuz";
            string aciklama = "Diyarbakır Karpuzu";
            double fiyati = 65;
            int stokadedi = 19;

            string[] meyve = new string[] { };


            Urun urun1 = new Urun();
            urun1.UrunAdi = "Karpuz";
            urun1.Aciklama = "Diyarbakır Karpuzu";
            urun1.Fiyati = 65;
            urun1.StokAdedi = 19;

            Urun urun2 = new Urun();
            urun2.UrunAdi = "Şeftali";
            urun2.Aciklama = "Bursa Şeftali";
            urun2.Fiyati = 58;
            urun2.StokAdedi = 78;

            Urun[] urunler = new Urun[] { urun1, urun2 };

            foreach (var Urunler in urunler)
            {
                Console.WriteLine(Urunler.UrunAdi);
                Console.WriteLine(Urunler.Aciklama);
                Console.WriteLine(Urunler.Fiyati);
                Console.WriteLine(Urunler.StokAdedi);
                Console.WriteLine("---------------");
            }

            SepetManager sepetManager = new SepetManager();
            sepetManager.ekle(urun1);
            sepetManager.ekle(urun2);

            sepetManager.ekle2("Karpuz", "Diyarbakır Karpuzu", 65, 19);
            sepetManager.ekle2("Şeftali", "Bursa Şeftalisi", 58, 78);




        }
    }
}
