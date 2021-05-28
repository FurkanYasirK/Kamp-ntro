using System;

namespace MusteriMetotDemo
{
    class Program
    {
        //Bir bankada müşteri takibi yapmak istiyorsunuz.
        //Musteri isimli bir Class oluşturunuz.Müşteriye istediğiniz özellikleri ekleyiniz. (Id, Ad, Soyad....)
        //MusteriManager sınıfı oluşturunuz.Musteri parametresi alarak Musteri ekleme, listeleme,silme gibi metotları simule ediniz.
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.MusteriAdi = "Furkan";
            musteri1.MusteriSoyad = "Kocagöl";
            musteri1.MusteriYas = 15;
            musteri1.AnneKızlıkSoy = "Karaman";

            Musteri musteri2 = new Musteri();
            musteri2.MusteriAdi = "Abdurrahim";
            musteri2.MusteriSoyad = "Kocagöl";
            musteri2.MusteriYas = 18;
            musteri2.AnneKızlıkSoy = "Karaman";

            Musteri musteri3 = new Musteri();
            musteri3.MusteriAdi = "Cemre";
            musteri3.MusteriSoyad = "Kocagöl";
            musteri3.MusteriYas = 11;
            musteri3.AnneKızlıkSoy = "Karaman";

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.MusteriEkle(musteri1);
            musteriManager.MusteriKaraListe(musteri2);
            musteriManager.MusteriSil(musteri3);


           

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };
            foreach (var herkes in musteriler)
            {
                Console.WriteLine("Bütün müşterilerimiz ve elimizdeki bütün bilgiler: " + herkes.MusteriAdi, herkes.MusteriSoyad, herkes.MusteriYas, herkes.AnneKızlıkSoy + herkes.MusteriAdi, herkes.MusteriSoyad, herkes.MusteriYas, herkes.AnneKızlıkSoy + herkes.MusteriAdi, herkes.MusteriSoyad, herkes.MusteriYas, herkes.AnneKızlıkSoy);
            }

        }
    }
}
