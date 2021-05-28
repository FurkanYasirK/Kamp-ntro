using System;
using System.Collections.Generic;
using System.Text;

namespace MusteriMetotDemo
{
    class MusteriManager
    {
        public void MusteriEkle(Musteri musteri)
        {
            Console.WriteLine(musteri.MusteriAdi + " " + musteri.MusteriSoyad + " " + "Kişisi Eklendi !!! ");
        }

        public void MusteriSil(Musteri musteri)
        {
            Console.WriteLine(musteri.MusteriAdi + " " + musteri.MusteriSoyad + " " + "Kişisi Silindi !!!");
        }

        public void MusteriKaraListe(Musteri musteri)
        {
            Console.WriteLine(musteri.MusteriAdi + " " + musteri.MusteriSoyad + " " + "Kişisi Kara Listeye Alındı");
        }


    }
}
