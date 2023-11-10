namespace OOP3
{
    class DemandManager
    {
        // Method Injection
        public void Demand(ICreditManager creditManager, ILoggerService loggerService)
        {
            creditManager.Calculate();
            loggerService.Log();
        }

        public void CreditInfo(List<ICreditManager> credits)
        {
            foreach ( var  credit in credits)
            {
                credit.Calculate();
            }
        }
    }
}