using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya elması";


            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır karpuzu";


            Urun[] urunler = new Urun[] { urun1, urun2 };


            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("***************");
            }


            Console.WriteLine("-------------Metotlar-----------");

            //instance - örnek
            //metotlar reusuability tekrar kullanilabilirlik işine yarar.
            //encapsulation ---
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);


            sepetManager.Ekle2("Armut","Yeşil armut",12,10);
            sepetManager.Ekle2("Elma", "Yeşil elma", 14,7);
            sepetManager.Ekle2("Karpuz", "Diyarbakır karpuzu", 15,9);



        }
    }
}


//dont repeat yourself - dry - Clean Code - Best Practice
//tekrar tekrar kullandıgımız kodları metotlara yazarız
//örnek sepete ekle butonu