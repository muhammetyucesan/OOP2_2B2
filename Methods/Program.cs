using System.Reflection.Emit;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string productName = "Elma";
            double price = 15;
            string description = "Amasya elması";

            string[] meyveler = new string[] { };

            Product product1 = new Product();
            product1.Name = "elma";
            product1.Price = 15;
            product1.Description = "Amasya elması";

            Product product2 = new Product();
            product2.Name = "Karpuz";
            product2.Price = 80;
            product2.Description = "Diyarbakırdan";

            Product[] products = new Product[] { product1, product2 };

            //type-safe -- tip güvenli
            foreach (Product product in products) //product yerine x de yazabilirim. var yerine Product yazabiliriz.
            {
                Console.WriteLine(product.Name);    
                Console.WriteLine(product.Price);   
                Console.WriteLine(product.Description);
                Console.WriteLine("----------");
            }

            Console.WriteLine("------Metotlar-----");
            Console.WriteLine("");

            //instance - örnek
            //encapsulation

            SepetManager sepetManager = new SepetManager();
            sepetManager.Add(product1);
            sepetManager.Add(product2);

            sepetManager.Add2("Armut", "Yeşil armut", 12, 10);
            sepetManager.Add2("Elma", "Yeşil elma", 12, 9);
            sepetManager.Add2("Karpuz", "Diyarbakırdan", 12, 8);

        }
    }
}