using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety tip güvenliği
            // Do not repeat kendini tekrarlama
            //değer tutucu, alias

            string kategoriEtiketi = "Kategori" ;
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemGirisYapmisMi = true ;
            double dolarDun = 7.55;
            double dolarBugun = 7.55;

            if (dolarDun > dolarBugun)
            {
                Console.WriteLine("Azalış Buton");
            }
            else if (dolarDun < dolarBugun)
            {
                Console.WriteLine("Artış Butonu");
            }
            else
            {
                Console.WriteLine("Değişmedi Butonu");
            }

            if (sistemGirisYapmisMi == true)
            {
                Console.WriteLine("Kullanıcı Ayarları Butonu");
            }
            else
            {
                Console.WriteLine("Giriş yap butonu");
            }

            Console.WriteLine(kategoriEtiketi);
        }
    }
}
