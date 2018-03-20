using System;
namespace Mod1_SAL
{
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        private static int studentCount = 0;

        public Student()
        {
            studentCount++;
        }

        public Student(string firstName, string lastName){
            this.FirstName = firstName;
            this.LastName = lastName;
            studentCount++;
        }
        public static int CountStudents(){
            return studentCount;
        }
    }
}
