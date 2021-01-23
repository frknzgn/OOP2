using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class VehicleCreditManager : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("Araç krediniz hesaplandı.");
        }

        public void DoSomeThing()
        {
            Console.WriteLine("Araç bir şeyi yapıldı.");
        }
    }
}
