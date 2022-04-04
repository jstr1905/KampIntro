using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsIntro
    //constructor olduğunu classla aynı isim olduğundan anlarız o da aslında bir metot
{
    class MyList<T>//T istediğim elemanın yerini alır 
                   //T type 
    {
        T[] items;
        //constructor
        //ctor tab tab yaptık 
        //bir class newlendiğinde çalışan bloğa constructor deniyor
        public MyList()
        {
            items = new T[0];
        }
        public void Add(T item)
        {
            T[] tempArray = items;//newlediğimiz anda yeni referans numarası aldığı için (o referansı birine tutturmamız lazım) elemanlarımızın kaybolmaması için geçici olarak bir string arraye (tempArray) tutturuyoruz.
            items = new T[items.Length + 1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];//
                                        //değerleri itemse geri alıyoruz.
            }
            items[items.Length - 1] = item;//aslında eklemem gereken elemanı şu an ekledim
        }
    }
}
//"Eğer zorlanmazsan gelişemezsin"