using System;

namespace BoatFirstVoyage
{

//Open closed principle: it can be and is extended yet the class is not modified
//Liskov subsitution principle: the child classes extend the parent class
// Interface segregation principle: the interface is only implemented when it is needed, and then it is used diffretnly 
//to cater for the needs of each child class
//Dependancy inversion: interfaces use the methods differently but is accessible to both

   public  class FullTime: Student , IWorkFromHome
    {
        private String campus;

        
        public FullTime(String fName,String lName,String stuNo, String campus): base(fName,lName, stuNo )
        {
           this.campus = campus;

        }

        public FullTime()
        {
            
        }

        public String getCampus()
        {
            return this.campus;
        }

        public void setCampus(String campus)
        {
            this.campus = campus;
        }

        public void studyFromHome()
        {
              System.Console.WriteLine("I study at home differently to the house hermmit.");
        }

         public override string ToString()
             {
                  return this.getStuNo()+"|"+this.getFName()+"|"+this.getLName()+"|"+campus;
             }


    }

	
}

