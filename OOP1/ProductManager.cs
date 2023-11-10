using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    internal class ProductManager
    {
        public void Add(Product product)  //Bana bir product ver diyoz burada. Add(string ad) gibi de olabilir. aynı mantık. alıyoz-çağırıyoz böyle.
        {
            Console.WriteLine(product.ProductName +"eklendi");
        }

        public void Update(Product product) 
        {
            Console.WriteLine(product.ProductName + "güncellendi");
        }


    }
}
