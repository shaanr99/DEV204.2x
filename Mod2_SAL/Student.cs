using System;
namespace Mod2_SAL
{
    class Student : Person
    {
        private int graduationYear;
        //private int studentID;
        public int GraduationYear { get => graduationYear; set => graduationYear = value; }
        //public int StudentID { get => studentID; }
        public Student(string first, string last):base(first, last)
        {
            this.FirstName = first;
            this.LastName = last;
            //this.ID = studentID++;
        }

        public void TakeTest()
        {
            Console.WriteLine(this.FirstName + " " + this.LastName + " is now taking a test!");
        }

        public override String StateSomething()
        {
            return "Something has been stated by the student with ID: " + getID();
        }

    }
}
