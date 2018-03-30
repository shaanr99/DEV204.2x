using System;
using System.Collections;
using System.Collections.Generic;

namespace Mod2_SAL
{
    class Program
    {
        private static List<Student> students = new List<Student>();
        private static Teacher teacher = new Teacher("Ima","Teechor");

        static void Main(string[] args)
        {
            // do some teacher stuff ...
            teacher.Degree = "Master of Education";
            CreateStudents();
            Console.WriteLine("The teacher is {0} {1} from {2} with ID {3}", teacher.FirstName, teacher.LastName, teacher.Degree, teacher.getID());
            teacher.GiveATest("A REALLY hard test");

            Console.WriteLine("-----------------------------------");

            foreach (Student s in students)
            {
                Console.WriteLine("-----------------------------------");
                Console.WriteLine("First name:  {0}, Last name: {1}, Graduation: {2}, Student ID: {3}", s.FirstName, s.LastName, s.GraduationYear, s.getID());
                s.StateSomething();
                s.TakeTest();
            }

            Student myStudent = new Student("Harry", "Hidleman");
            Person myPerson = myStudent;


        }

        private static void CreateStudents()
        {
            students.Add(new Student("John", "Doe"));
            students.Add(new Student("Bob", "Barker"));
            students.Add(new Student("Sally", "Fields"));
            students.Add(new Student("Jane", "Goodall"));
        }
     }
}
