using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string> sehirler = new Dictionary<string>();
            sehirler.Add("İstanbul");
            sehirler.Add("Ankara");
            sehirler.Add("Bursa");
            sehirler.Add("Balıkesir");
            Console.WriteLine(sehirler.Count);
        }
    }
}
