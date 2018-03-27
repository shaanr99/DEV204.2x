using System;
namespace Mod2_Lab1
{
    public class Employee
    {
        private string employeeName;
        private double employeeBaseSalary;
        private int employeeId;
        private static int employeeCount = 1;

        // encapsulated
        public string Name { get => employeeName; set => employeeName = value; }
        public double BaseSalary { get => employeeBaseSalary; set => employeeBaseSalary = value; }
        public int ID { get => employeeId; set => employeeId = value; }

        public Employee(String name, double baseSalary)
        {
            this.Name = name;
            this.BaseSalary = baseSalary;
            this.ID = employeeCount++;
        }

        // this method returns the employee's base salary
        public double getBaseSalary()
        {
            return this.BaseSalary;
        }

        // this method returns the employee's name
        public String getName()
        {
            return this.Name;
        }

        // this method returns the employee's ID
        public int getEmployeeID()
        {
            return this.ID;
        }

        // this method returns the employee's ID and Name as a string
        public String toString()
        {
            return this.ID + " " + this.Name;
        }

        // return a String representation of that Employee's current status 
        // and state that they are in the company system
        // NOTE:  Other classes should be able to overide this method
        public virtual String employeeStatus()
        {
            return toString() + " is in the company's system";
        }
    }
}
