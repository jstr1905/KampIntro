using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.Adi = "Yusuf";
            musteri1.Soyadi = "Yıldız";
            musteri1.TCKimlikNo = "11122233344";
            musteri1.Yasi = 21;


            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.Adi = "Ekrem";
            musteri2.Soyadi = "Kızılay";
            musteri2.TCKimlikNo = "44433322211";
            musteri2.Yasi = 20;


            Musteri musteri3 = new Musteri();
            musteri3.Id = 3;
            musteri3.Adi = "Fatih";
            musteri3.Soyadi = "Acar";
            musteri3.TCKimlikNo = "11122233444";
            musteri3.Yasi = 20;


            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };
            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine(musteri.Id);
                Console.WriteLine(musteri.Adi);
                Console.WriteLine(musteri.Soyadi);
                Console.WriteLine(musteri.TCKimlikNo);

            }
            Console.WriteLine("-------------Metotlar-----------");
            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
            musteriManager.Ekle(musteri3);

            musteriManager.Silme(musteri1);
            musteriManager.Listele(musteri3);

            musteriManager.Guncelleme("Ekrem","Kızılay",20);

        }
    }
}
