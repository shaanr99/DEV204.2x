using System;

namespace Mod1_SAL
{
    class Program
    {
        static void Main(string[] args)
        {
            UProgram labProgram = new UProgram("Information Technology");
            Degree degree = new Degree("Bachelors");
            Course course = new Course("Programming with C#");

            // create students
            Student stud1 = new Student("John", "Doe");
            Student stud2 = new Student("Sally", "Freeman");
            Student stud3 = new Student("Kyle", "Wallace");

            // create teacher
            Teacher teacher = new Teacher("Mr.", "Wabernacker");

            // add students and teachers to Course
            course.Students.Add(new Student("John", "Doe"));
            course.Students.Add(stud2);
            course.Students.Add(stud3);
            course.Teachers.Add(teacher);

            // Add the course to a degree 
            degree.Courses.Add(course);

            // Add the degree to a program
            labProgram.Degrees.Add(degree);

            Console.WriteLine($"Program:  {labProgram.Name}");
            foreach(Degree d in labProgram.Degrees){
                Console.WriteLine($"Degree:  {d.Name}");
                foreach(Course c in d.Courses){
                    Console.WriteLine($"Course:  {c.Name}");
                    foreach(Student s in c.Students){
                        Console.WriteLine($"Student:  {s.FirstName} {s.LastName}");
                    }
                    foreach(Teacher t in c.Teachers){
                        Console.WriteLine($"Teacher:  {t.FirstName} {t.LastName}");
                    }
                }
            }
        }
    }
}
