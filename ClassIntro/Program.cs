using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "Yiğit";
            int yasi = 27;

            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Yiğit Mmc";
            kurs1.IzlemeOrani =69;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Java";
            kurs2.Egitmen = "Salih Cuğ";
            kurs2.IzlemeOrani =31;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Phyton";
            kurs3.Egitmen = "İlkcan JeyJey";
            kurs3.IzlemeOrani =12;

            Kurs kurs4 = new Kurs();
            kurs4.KursAdi = "C ++";
            kurs4.Egitmen = "Emre Zargana";
            kurs4.IzlemeOrani = 5;


            //Console.WriteLine(kurs1.KursAdi + " : " + kurs1.Egitmen);

            Kurs[] kurslar = new Kurs[] {kurs1, kurs2, kurs3, kurs4 };

            foreach (var kurs  in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + " : " + kurs.Egitmen);
            }
        }
    }


    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int IzlemeOrani { get; set; }

    }
}
