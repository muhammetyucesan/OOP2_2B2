using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class SepetManager
    {
        //naming convention
        //syntax
        public void Add(Product product)
        {
            Console.WriteLine("Tebrikler.Sepete eklendi."+product.Name);
        }

        public void Add2(string productName, string description, double price, int stockQuantity)
        {
            Console.WriteLine("Tebrikler.Sepete eklendi." + productName);
        }
    }
}
