using System;

namespace Gun2Odev6
{
    class Program
    {
        static void Main(string[] args)
        {
            Computers product1 = new Computers();
            product1.productId = 1;
            product1.productName = "Lenovo";
            product1.productCpu = "i7 10870H";
            product1.productGpu = "Gtx1080";
            product1.productPrice = 10000;



            Computers product2 = new Computers();
            product2.productId = 3;
            product2.productName = "Msi";
            product2.productCpu = "i7 11800H";
            product2.productGpu = "Rtx3080";
            product2.productPrice = 13000;



            Computers product3 = new Computers();
            product3.productId = 5;
            product3.productName = "Asus";
            product3.productCpu = "i7 10750H";
            product3.productGpu = "Gtx1060";
            product3.productPrice = 7000;


            Computers[] products = new Computers[] { product1, product2, product3 };
            foreach (var product in products)
            {
                Console.WriteLine(product.productId + " : " + product.productName + " : " + product.productCpu + " : " + product.productGpu + " : " + product.productPrice + "TL");
            }
            Console.WriteLine("*** for döngüsü ***");
            for (int i = 0; i < products.Length; i++)
            {
                Console.WriteLine(products[i].productId + " : " + products[i].productName + " : " + products[i].productCpu + " : " + products[i].productGpu + " : " + products[i].productPrice + "TL");
            }
            Console.WriteLine("*** while döngüsü ***");
            int j = 0;
            while (j < products.Length)
            {
                Console.WriteLine(products[j].productId + " : " + products[j].productName + " : " + products[j].productCpu + " : " + products[j].productGpu + " : " + products[j].productPrice + "TL");
                j++;
            }



        }

        class Computers
        {

            public int productId { get; set; }
            public string productName { get; set; }
            public string productCpu { get; set; }
            public string productGpu { get; set; }
            public int productPrice { get; set; }
            //prop yazıp tab tab yapıyoruz



        }
    }
}
