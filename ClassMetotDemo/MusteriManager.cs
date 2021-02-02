using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Add(Musteri musteri)
        {
            Console.WriteLine("Yeni müşteri eklendi : " + musteri.Adi + " " + musteri.Soyadi+"\n");
        }

        public void Delete(Musteri musteri)
        {
            Console.WriteLine("Müşteri silindi : " + musteri.Adi + " " + musteri.Soyadi+"\n");
        }

        //public void Liste(Musteri musteri)
        //{
        //    Console.WriteLine("Müşteri \n "+ "Muşteri ID : "+ musteri.MusteriId +"\n Adı : "+ musteri.Adi 
        //        +"\n Soyadı : "+  musteri.Soyadi+ "\n Müşteri Numarası : "+musteri.MusteriNo);
        //}

        public void List(params Musteri[] musteri)
        {
            foreach(Musteri must in musteri)
            {
                Console.WriteLine(must.Adi + " " + must.Soyadi + "\n");
            }
        }
    }
}
