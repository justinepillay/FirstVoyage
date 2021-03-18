using System;
using System.Collections.Generic;

namespace BoatFirstVoyage
{
    class Program
    {
        
           
        static void Main(string[] args)
        {
           
            ListWorker lWorker = new ListWorker();

            foreach(FullTime student in lWorker.getLstFullTime())
            {
                Console.WriteLine(student.getFName()+"");
            }

        }
    }
}
