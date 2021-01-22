using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri = new Musteri();
            musteri.Ad = "Omer";
            musteri.Soyad = "Eser";
            musteri.Yas = 22;
            Musteri musteri2 = new Musteri();
            musteri2.Ad = "Erhan";
            musteri2.Soyad = "Ercan";
            musteri2.Yas = 28;
            MusteriManager MM = new MusteriManager();
            MM.Ekle(musteri);
            Musteri[] Mlist = new Musteri[] { musteri, musteri2 };
            MM.Listele(Mlist);
        }
    }
}
