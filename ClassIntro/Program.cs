using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            int yas = 33;
            string adi = "engin";
            Kurs kurs1 = new Kurs();//sanki kendi veri tipimizi yazıyormuşuz gibi düşünelim.
            kurs1.KursAdi = "c++ ";
            kurs1.Egitmen = "engin demiroğ";
            kurs1.IzlenmeOrani = 85;



            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "c#";
            kurs2.Egitmen = "berkay bilgin";
            kurs2.IzlenmeOrani = 95;


            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "java ";
            kurs3.Egitmen = "kerem varış";
            kurs3.IzlenmeOrani = 45;


            //Console.WriteLine(kurs1.KursAdi+" : "+kurs1.Egitmen);
            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3 };

            foreach (Kurs kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + " : " + kurs.Egitmen);
            }


        }
    }
    //classlar birden fazla veri tipini tutmaya yarar.
    //prop
    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int IzlenmeOrani { get; set; }

    }
}
