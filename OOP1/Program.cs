namespace OOP1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 1;
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitsInStock = 3;

            Product product2 = new Product(); { Id = 2, CategoryId=5, UnitsInStock=5,
                                                ProductName="Kalem", UnitPrice=35      };
            
            ProductManager productManager = new ProductManager(); //pascal case vs camel case
            //case sensitive
            //productManager herhangi bir harf de olabilir. ProductManager classımız.
            productManager.Add(product1) //bunu ProductManager a göndermiş oluyoruz böylece. o da orada tutacak.
            


        }
    }
}