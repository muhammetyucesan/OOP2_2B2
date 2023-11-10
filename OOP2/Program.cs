namespace OOP2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Customer customer1 = new Customer();
            //customer1.CustomerName = "Engin";
            //customer1.CustomerLastName = "Demiroğ";
            //customer1.CustomerId = 1;
            //Customer.IdentificationNumber = "222222222"
            //customer1.CustomerNumber = "12345"
            //// Gerçek kişi(bireyler) - Tüzel kişi(şirketler)

            IndividualCustomer customer1 = new IndividualCustomer(); //gerçek- bireysel müşteri
            customer1.CustomerId = 1;
            customer1.CustomerNumber = "12345";
            customer1.CustomerName = "Muhammet";    
            customer1.CustomerLastName = "Yücesan";
            customer1.IdentificationNumber = "12345678910";

            CorporateCustomer customer2 = new CorporateCustomer(); //tüzel müşteri
            customer2.CustomerId = 2;
            customer2.CustomerNumber = "54321";
            customer2.CompanyName = "Yücesan AŞ.";
            customer2.TaxNumber = "1234567890";

            //Customer classı hem gerçek hem tüzel müşteri referansını tutabiliyor;
            Customer customer3 = new IndividualCustomer();
            Customer customer4 = new CorporateCustomer();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1); 
            customerManager.Add(customer2); 
            // olaylar tamamen referans tipleri... Referans tutabilme.










        }
    }
}