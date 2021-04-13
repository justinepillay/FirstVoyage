namespace BoatFirstVoyage
{
     
     // Interface Segregation Principle:A client should never be forced to implement an 
     //interface that it doesn’t use or clients shouldn’t be forced to depend on methods they do not use.

     //In this case, both classes that implement this interface use the studyFromMethod(), although they 
     //may be implemented differently
        public  interface IWorkFromHome
    {
         void studyFromHome();

    }

	
}
