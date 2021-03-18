using System;

namespace BoatFirstVoyage
{
//Open closed principle: it can be and is extended yet the class is not modified


   public  class Distant: Student, IWorkFromHome
    {
        private String facilitator;

        
        public Distant(String fName,String lName,String stuNo, String facilitator): base(fName,lName, stuNo )
        {
           this.facilitator = facilitator;

        }


        public String getFacilitator()
        {
            return this.facilitator;
        }

        public void setFacilitator(String facilitator)
        {
            this.facilitator = facilitator;
        }

        public void studyFromHome()
        {
            System.Console.WriteLine("I am house hermit.");
        }


    }

	
}
