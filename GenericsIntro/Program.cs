using System;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //MyList isimler = new MyList(); bu şekilde olmuyor generic class olduğu için içerisinde olan metotlar tip bağımlı çalışıyor
            //calışıcağım veri tipini ver diyor.
            MyList<string> isimler = new MyList<string>();//int de verebiliriz class da verebiliriz //class türünde liste
            isimler.Add("Engin");

        }
    }
}
