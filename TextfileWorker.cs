using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace BoatFirstVoyage
{
    class TextfileWorker
    {

        List<FullTime> lstFullTime = new List<FullTime>();
        List<Distant> lstDistant = new List<Distant>();

        public void readInValues()
        {
            string line;
            FullTime fullTime = new FullTime();
            Distant distant = new Distant();
            try
            {
                StreamReader file = new StreamReader("Students.txt");
                while ((line = file.ReadLine()) !=null)
                {
                    var lineParts = line.Split('|');

                    if (lineParts[0].ElementAt(0).Equals('F'))
                    {
                       fullTime = new FullTime(lineParts[1], lineParts[2], lineParts[0], lineParts[3]);
                       lstFullTime.Add(fullTime);
                    }
                    else if(lineParts[0].ElementAt(0).Equals('D'))
                    {
                        distant = new Distant(lineParts[1], lineParts[2], lineParts[0], lineParts[3]);
                        lstDistant.Add(distant);
                    }
                }

                file.Close();
            }
            catch (FileNotFoundException)
            {

                StreamWriter sw = new StreamWriter("Students.txt");
                sw.Close();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

        }


        public void writeStudentToFile(Student student)
        {

            StreamWriter sw = new StreamWriter("Students.txt", true);
            sw.WriteLine(student.ToString());
            sw.Close();

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
