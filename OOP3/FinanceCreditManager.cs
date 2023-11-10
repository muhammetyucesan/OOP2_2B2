using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class FinanceCreditManager : ICreditManager //:CreditManager i ekledik. Hesapla kısmı orada zaten olduğu için.
    {
        public void Calculate()
        {
            //throw new NotImplementedException();
            Console.WriteLine("İhtiyaç kredisi ödeme planı hesaplandı");

        }

        public void DoMove()
        {
            throw new NotImplementedException();
        }
    }
}
