using System;
using System.Collections.Generic;

namespace BoatFirstVoyage
{
    class Program
    {
        
           
        static void Main(string[] args)
        {
           
            ListWorker lWorker = new ListWorker();
            bool returnToMenu = false;

            String option = lWorker.displayMenu();
            while((option.Equals("0")||option.Equals("1")))
            {
                lWorker.performMenuAction(option);
                returnToMenu = lWorker.returnToMenu();
                if(returnToMenu)
                {
                    option = lWorker.displayMenu();
                }
                else
                {
                        option = "-1";
                }
                
            }
         
            Console.WriteLine("Bye!");
            System.Environment.Exit(0);

            
        }
    }
}
