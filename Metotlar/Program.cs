using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //string urunAdi = "Elma";
            //double fiyati = 15;
            //string aciklama = "Amasya Elması";

            //string[] meyveler = new string[] { };

            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elması";
            urun1.StokAdedi = 15;

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır Karpuzu";
            urun2.StokAdedi = 500;


            Urun[] urunler = new Urun[] {urun1 , urun2 };

            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine(urun.StokAdedi);
                Console.WriteLine("--------------------------");
            }

            Console.WriteLine("-------------------Metodlar-----------");

            //instance - örnek
            //encapsulation
            //Metodu çağırmak içn bu kodlar yazılmalıdır
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("Armut", "Yeşil Armut ", 12, 10);
            sepetManager.Ekle2("Elma", "Yeşil Elma", 12, 9);
            sepetManager.Ekle2("Karpuz", "Diyarbakır Karpuzu", 12, 8);


        }
    }
}

//Dont repeat yourself  - DRY - Clean Code - BestPactice
