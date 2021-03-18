using System;

namespace BoatFirstVoyage
{

//Single Responsibility Principle: The class handles student objects only.

   public abstract class Student 
    {
     private String fName;
        private String lName;
        private String stuNo;


          public Student(String fName,String lName,String stuNo)
        {
            this.fName = fName;
            this.lName = lName;
            this.stuNo = stuNo;

        }


	public String getFName() {
		return this.fName;
	}

	public void setFName(String fName) {
		this.fName = fName;
	}

	public String getLName() {
		return this.lName;
	}

	public void setLName(String lName) {
		this.lName = lName;
	}

	public String getStuNo() {
		return this.stuNo;
	}

	public void setStuNo(String stuNo) {
		this.stuNo = stuNo;
	}

    }
}
