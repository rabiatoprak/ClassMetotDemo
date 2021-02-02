using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.MusteriId = 11;
            musteri1.Adi = "Sevilay";
            musteri1.Soyadi = "Korkmaz";
            musteri1.MusteriNo = 112233;

            Musteri musteri2 = new Musteri();
            musteri2.MusteriId = 12;
            musteri2.Adi = "Rabia";
            musteri2.Soyadi = "Toprak";
            musteri2.MusteriNo = 332211;

            Musteri musteri3 = new Musteri();
            musteri3.MusteriId = 13;
            musteri3.Adi = "Şeymanur";
            musteri3.Soyadi = "Terzioğlu";
            musteri3.MusteriNo = 888888;

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Add(musteri1);
            musteriManager.Delete(musteri2);
            musteriManager.List(musteri1, musteri2, musteri3);


        }
    }
}
