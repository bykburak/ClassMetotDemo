using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.MusteriAdi = "Burak";
            musteri1.MusteriSoyadi = "Büyükkara";
            musteri1.TcKimlikNo = "28890392543";

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.MusteriAdi = "Ali";
            musteri2.MusteriSoyadi = "Veli";
            musteri2.TcKimlikNo = "34675592543";

            Musteri musteri3 = new Musteri();
            musteri3.Id = 3;
            musteri3.MusteriAdi = "Selami";
            musteri3.MusteriSoyadi = "Solak";
            musteri3.TcKimlikNo = "45678469753";

            Musteri[] musteri = new Musteri[] {musteri1,musteri2,musteri3};

            MusteriManager musteriManager = new MusteriManager();

            foreach (var musteriListele in musteri)
            {
                musteriManager.TumMusterileriListele(musteriListele);
            }

            musteriManager.Ekle(musteri1);

            musteriManager.Sil(musteri3);

        }
    }
}
