using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodDemo
{
    class MusteriManager
    {
        public static void MusteriEkleme(Musteri musteri)
        {
            Console.WriteLine(musteri.Ad + " " + musteri.Soyad + "sisteme eklenmiştir.");
        }

        public static void MusteriListeleme(Musteri[] musteriListe)
        {
            foreach (Musteri musteri in musteriListe)
            {
                Console.WriteLine(musteri.Id + musteri.Ad + musteri.Soyad);
            }
        }

        public static void MusteriSilme(Musteri musteri)
        {
            Console.WriteLine("ID'si " + musteri.Id + "olan " + musteri.Ad + musteri.Soyad + "sistemden silinmiştir.");
        }
    }
}
