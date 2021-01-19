using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Listele(Musteri musteri)
        {
            Console.WriteLine("MÜŞTERİ lİSTELEME SIMULASYONU");

            Console.WriteLine("ID: " + musteri.Id + "\n"+ "Adı: " + musteri.MusteriAdi + "\n" + 
                "SoyAdı: " + musteri.MusteriSoyadi + "\n" + "TCKN: " + musteri.TcKimlikNo +"\n" + "*********************************");
        }

        //
        public void TumMusterileriListele(Musteri musteri)
        {
            Console.WriteLine("TÜM MÜŞTERİ lİSTELEME SIMULASYONU");

            Console.WriteLine("ID: " + musteri.Id + "\n" + "Adı: " + musteri.MusteriAdi + "\n" +
                "SoyAdı: " + musteri.MusteriSoyadi + "\n" + "TCKN: " + musteri.TcKimlikNo + "\n" + "*********************************");
        }


        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("MÜŞTERİ EKLEME SIMULASYONU");
            Console.WriteLine("Tebrikler! Müşteri Sisteme Başarıyla Eklendi!");
            Console.WriteLine("Müşteri Bilgileri: ");
            Listele(musteri);
        }

        public void Sil(Musteri musteri)
        {
            Console.WriteLine("MÜŞTERİ SİLME SIMULASYONU");
            Console.WriteLine("Tebrikler! Müşteri silme işlemi başarılı bir şekilde gerçekleştirildi!");
            Console.WriteLine("Müşteri Bilgileri: ");
            Listele(musteri);
        }
    }
}
