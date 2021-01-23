using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class HousingCreditManager : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("Konut kredisi hesaplandı.");
        }

        public void DoSomeThing()
        {
            Console.WriteLine("Konut bir şeyi yapıldı.");
        }
    }
}
