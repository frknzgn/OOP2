using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class ApplicationManager
    {
        public void Apply(ICreditManager creditManager,List<IloggerService> loggers)
        {
            //Başvuran bilgilerini değerlendir.
            creditManager.Calculate();
            creditManager.DoSomeThing();

            foreach (var logger in loggers)
            {
                logger.Log();
            }
            

        }

        public void MakeEnlightenment(List<ICreditManager> credits)
        {
            foreach (var credit in credits)
            {
                credit.Calculate();
            }
        }
    }
}
