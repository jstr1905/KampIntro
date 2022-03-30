using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım geliştirici kursu";
            string kurs2 = "Programlamaya başlangıç için temel kurs";
            string kurs3 = "Java";


            //array - dizi
            string[] kurslar = new string[] { "Yazılım geliştirici kursu" ,
                "Programlamaya başlangıç için temel kurs",
                "Java","Python" };

            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("***************");
            foreach (string kurs in kurslar)// kurs burda takma isim xyz de olabilir
            {
                Console.WriteLine(kurs);

            }


            Console.WriteLine("sayfa sonu - footer");
        }
    }
}
