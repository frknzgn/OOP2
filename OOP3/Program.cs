using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            ICreditManager requirementCreditManager = new RequirementCreditManager();        
            ICreditManager vehicleCreditManager = new VehicleCreditManager();      
            ICreditManager housingCreditManager = new HousingCreditManager();

            //IloggerService databaseLoggerService = new DataBaseLoggerService();
            //IloggerService fileLoggerService = new FileLoggerService();
            List<IloggerService> loggers = new List<IloggerService>() {new  FileLoggerService(),new  DataBaseLoggerService() };

            ApplicationManager applicationManager = new ApplicationManager();
            applicationManager.Apply(vehicleCreditManager,new List<IloggerService>() {new DataBaseLoggerService() , new FileLoggerService() });
            applicationManager.Apply(housingCreditManager,loggers);

            List<ICreditManager> credits = new List<ICreditManager>() {requirementCreditManager,housingCreditManager };
            //applicationManager.MakeEnlightenment(credits);


        }
    }
}
