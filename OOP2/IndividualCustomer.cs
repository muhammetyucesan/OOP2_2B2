using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    //bireysel(gerçek) müşteri classı
    internal class IndividualCustomer : Customer    //bireysel(gerçek) müşteri bir müşteridir demek : Customer kısmı.

    {
        public string IdentificationNumber { get; set; }
        public string CustomerName { get; set; }
        public string CustomerLastName { get; set; }
                

    }
}
