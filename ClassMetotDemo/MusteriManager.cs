using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Müşteri eklendi " + musteri.Id + " " + musteri.Adi + " " + musteri.Soyadi + " " + musteri.Yasi);
        }
        public void Silme(Musteri musteri)
        {
            Console.WriteLine("Müşteri silindi : " + musteri.Id + " " + musteri.Adi + " " + musteri.Soyadi + " " + musteri.Yasi);
        }

        public void Listele(Musteri musteri)
        {
            Console.WriteLine("Müşteri listelendi : " + musteri.Id + " " + musteri.Adi + " " + musteri.Soyadi + " " + musteri.Yasi);
        }
        public void Guncelleme(string musteriAdi, string musteriSoyadi, int musteriYasi)
        {

            Console.WriteLine("Başarılı güncellendi : " + musteriAdi + " " + musteriSoyadi);

        }


    }
}
