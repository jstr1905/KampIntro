using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    class SepetManager
    {
        //naming convention
        //syntax
        public void Ekle(Urun urun)//parametre ekliyoruz (tipi - isimlendirme)

        {
            Console.WriteLine("Başarılı.Sepete eklendi : " + urun.Adi);

        }

        public void Ekle2(string urunAdi,string aciklama,double fiyat,int stokAdedi) {

            Console.WriteLine("Başarılı.Sepete eklendi : " + urunAdi);

        
        }
    }
}