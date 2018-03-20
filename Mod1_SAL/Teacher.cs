using System;
namespace Mod1_SAL
{
    public class Teacher
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        private static int teacherCount = 0;

        public Teacher()
        {
            teacherCount++;
        }
        public Teacher(string firstName, string lastName){
            this.FirstName = firstName;
            this.LastName = lastName;
            teacherCount++;
        }
        public static int CountTeachers(){
            return teacherCount;
        }
    }
}
