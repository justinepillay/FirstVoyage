using System;
using System.Collections.Generic;


namespace BoatFirstVoyage
{

//class to handle the list of distant and full time students
        public class ListWorker
        {

            List<FullTime> lstFullTime = new List<FullTime>();
            List<Distant> lstDistant = new List<Distant>();
            TextfileWorker tfWorker = new TextfileWorker();

            public ListWorker()
            {

                //calls the method in the textfile class to read in the values 
                tfWorker.readInValues();

                // populates the lists
                this.lstFullTime = tfWorker.getLstFullTime();
                this.lstDistant = tfWorker.getLstDistant();        
            }




        //method to display the menu from the user and returns the selected option from the console
            public String displayMenu()
            {

                Console.Clear();
                String option = "";
                System.Console.WriteLine("*****************************************");
                System.Console.WriteLine("Select an option below:\n\n");
                System.Console.WriteLine("1. Add Student [0]\n2. View Student [1]\n\n Press any other key to exit.");
                option = Console.ReadLine();
                return option;

            }


//          method receives a option and calls the relevant method
            public void performMenuAction(String option)
            {
                    switch(option)
                {
                    case "0":
                      addStudent();
                    break;
                    case "1":
                        viewStudents();
                    break;
                    
                }
            }


//       method to add a student to the list and also to the tf
            public void addStudent()
            {

                String studentType = "";
                String fName = "";
                String lName="";
                String stuId= "";
                System.Console.WriteLine("Would you like to add a Full Time student [F] or Distant student [D]? (Enter in F or D)");
                studentType = Console.ReadLine();

                while(!(studentType.Equals("F")||studentType.Equals("D")))
                {
                     System.Console.WriteLine("Please select 'F' for full time student or 'D' for distant student. ");
                     studentType = Console.ReadLine();

                }

                    System.Console.Write("Student first name >>");
                    fName = Console.ReadLine();

                    System.Console.Write("Student last name >>");
                    lName = Console.ReadLine();

                     System.Console.Write("Student ID >>");
                     stuId = Console.ReadLine();
                
                switch (studentType)
                {
                    case "F":
                     String campus = "";
                     System.Console.Write("Campus >>");
                     campus = Console.ReadLine();

                     FullTime newFullTime= new FullTime(fName, lName, stuId, campus);
                     tfWorker.writeStudentToFile(newFullTime);
                     lstFullTime.Add(newFullTime);
                    break;

                    case "D":
                    String facilitator = "";
                    System.Console.Write("Facilitator >>");
                    facilitator = Console.ReadLine();

                    Distant newDistant= new Distant(fName, lName, stuId, facilitator);
                    tfWorker.writeStudentToFile(newDistant);
                    lstDistant.Add(newDistant);
                    break;
                }
           
            }


//          displays a list of the full time and distant students to the user 
            public void viewStudents()
            {
                 System.Console.Write("FULL TIME STUDENTS:\n\n");
                 foreach(FullTime fullStu in lstFullTime)
                  {
                     Console.WriteLine(fullStu.getStuNo() +" :  "+ fullStu.getFName());

                  }
                   System.Console.Write("\n\nDISTANT STUDENTS:\n\n");
                 foreach(Distant distantStu in lstDistant)
                   {
                      Console.WriteLine(distantStu.getStuNo() +" :  "+ distantStu.getFName());
                   }
            }


//              method to ask the user if they want to return to the main menu
            public bool returnToMenu()
            {
                String response ="";
                bool returnMenu = false;
                System.Console.WriteLine("Return to menu? [y/N]");
                response= Console.ReadLine();

                while(!(response.Equals("y")||response.Equals("N")))
                {
                    System.Console.WriteLine("Enter 'y' to return to menu or 'N' to exit the application.");
                    response= Console.ReadLine();
                }

                if(response.Equals("y"))
                {
                   returnMenu = true;
                }
                else
                {
                  returnMenu = false;
                }
                return returnMenu;
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