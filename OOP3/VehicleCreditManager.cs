using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class VehicleCreditManager : ICreditManager //:CreditManager i ekledik. Hesapla kısmı orada zaten olduğu için.
    {
        public void Calculate()
        {
            //throw new NotImplementedException();
            Console.WriteLine("Taşıt kredisi ödeme planı hesaplandı");

        }

        public void DoMove()
        {
            throw new NotImplementedException();
        }
    }
}
