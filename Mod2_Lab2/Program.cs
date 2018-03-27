using System;

namespace Mod2_Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiates Employee Object with name Libby and salary 2000 called employee1
            // now that we've gone all abstract, we can't use this line of code!
            //var employee1 = new Employee("Libby", 2000);

            // instead, let's make her a technical employee
            var employee1 = new TechnicalEmployee("Libby");

            // Instantiates TechnicalEmployee Object with name Zaynah called employee2
            var employee2 = new TechnicalEmployee("Zaynah");

            // Instantiates BusinessEmployee Object with name Winter called employee3
            var employee3 = new BusinessEmployee("Winter");

            // output to console window
            Console.WriteLine(employee1.employeeStatus() + " ... " + employee2.employeeStatus() + "..." + employee3.employeeStatus());
        }
    }
}
