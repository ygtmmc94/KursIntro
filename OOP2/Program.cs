using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "Yiğit";
            musteri1.Soyadi = "Mmc";
            musteri1.TcNo = "12345678910";


            // yapıkredi

            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "1903";
            musteri2.SirketAdi = "Mmc.co";
            musteri2.VergiNo = "1234567890";






            // Gerçek Müşteri - Tüzel Müşteri
            // SOLID kavramları 

            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();


            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);


        }
    }
}
