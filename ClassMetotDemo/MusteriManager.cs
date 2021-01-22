using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Tebrikler. Musteri Eklendi : " + musteri.Ad);
        }
        
        public void Listele(Musteri[] musteriler)
        {
            foreach (Musteri musteri1 in musteriler)
            {
                Console.WriteLine(musteri1.Ad);
                Console.WriteLine(musteri1.Soyad);
                Console.WriteLine(musteri1.Yas);
                Console.WriteLine("------------------");

            }
        }
    }
}
