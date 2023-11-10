namespace OOP3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // FinanceCreditManager financeCreditManager = new FinanceCreditManager(); böyle de olurdu;
            ICreditManager financeCreditManager = new FinanceCreditManager(); //baslarına ICreditManager classı ekledik. bu da diğerlerinin referanslaırını tutabiliyor ICreditManager classımız

            //VehicleCreditManager vehicleCreditManager = new VehicleCreditManager();
            ICreditManager vehicleCreditManager = new VehicleCreditManager();

            //HouseCreditManager houseCreditManager = new HouseCreditManager(); ilk hali
            ICreditManager houseCreditManager = new HouseCreditManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLogerService = new FileLoggerService();


            DemandManager demandManager = new DemandManager();
            demandManager.Demand(financeCreditManager, new DatabaseLoggerService());

            List<ICreditManager> credits = new List<ICreditManager>() { financeCreditManager, vehicleCreditManager};

           // demandManager.CreditInfo(credits);

        }
    }
}