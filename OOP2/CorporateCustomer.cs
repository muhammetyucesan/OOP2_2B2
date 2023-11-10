using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    //tüzel müşteri classı
    //miras-inheritance
    internal class CorporateCustomer : Customer  //tüzel müşteri bir müşteridir demek bu.
                                                   //müşteride olan herşey tüzel müşteride de var diye kabul edilir.
    {
        public int CustomerId { get; set; }
        public string CustomerNumber { get; set; } // mat işlemi yapılmayacagı için string kullandık.
        public string CompanyName { get; set; }
        public string TaxNumber { get; set; } // mat işlemi yapılmayacagı için string.
    }
}
