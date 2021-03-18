using System;
using System.Collections.Generic;

namespace BoatFirstVoyage
{
    
   public  class ListWorker
    {

       List<FullTime> lstFullTime = new List<FullTime>();
       List<Distant> lstDistant = new List<Distant>();
       TextfileWorker textfileWorker= new TextfileWorker();
     public ListWorker()
     {
        

     }


     


     public List<FullTime> getLstFullTime()
     {
         return lstFullTime;
     }

     public List<Distant> getLstDistant()
     {
         return lstDistant;
     }




        


	
    }
}
