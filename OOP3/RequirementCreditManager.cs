using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class RequirementCreditManager : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("İhtiyaç Krediniz hesaplandı.");
        }

        public void DoSomeThing()
        {
            Console.WriteLine("Bir şey yapıldı.");
        }
    }
}
