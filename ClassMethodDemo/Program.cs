using System;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 34874;
            musteri1.Ad = "Ahmet Emre";
            musteri1.Soyad = "Apo";

            Musteri musteri2 = new Musteri();
            musteri2.Id = 34875;
            musteri2.Ad = "Eren";
            musteri2.Soyad = "Aydın";

            Musteri musteri3 = new Musteri();
            musteri3.Id = 34876;
            musteri3.Ad = "Ceren";
            musteri3.Soyad = "Güler";



            





        }


    }

    class Musteri
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
    }
}
