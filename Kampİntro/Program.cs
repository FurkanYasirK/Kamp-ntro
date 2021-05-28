using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kampİntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety = tip güvenliği
            string kategoriEtiketi = "Kategori";
            int ogrenciSayisi = 32000; // sadece tam sayı tutabiliriz
            double faizOranı = 1.45; //double ile ondalıklı sayı tutabiliriz
            bool sistemeGirisYaptiMi = true; // bool ile sadece true false değeri tutabiliriz
            double dolarDun = 7.35;
            double dolarBugun = 7.75;

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalış butonu ");
            }
            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("Yükseliş butonu ");
            }
            else if (dolarDun==dolarBugun)
            {
                Console.WriteLine("Eşitlik butonu ");
            }

            if (sistemeGirisYaptiMi == true)// eğer ki girilen şart true ise parantez içerisine yazılan kod çalışır
            {
                Console.WriteLine("Kullanıcı ayarları butonu ");
            }
            else // eğer ki yukarıdaki şart false ise ne yapılacağını yazarız
            {
                Console.WriteLine("Giriş yap butonu ");
            }
            Console.WriteLine(kategoriEtiketi);
            Console.ReadLine();
        }
    }
}
