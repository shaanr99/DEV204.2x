using System;
namespace Mod2_OOPS
{
    public class AbstractClass
    {
        public AbstractClass()
        {
        }
    }
    abstract class EmployeeAbs
    {
        private string empNumber;
        private string firstName;
        private string lastName;
        private string address;


        public string EmpNumber
        {
            get { return empNumber; }
            set { empNumber = value; }
        }
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        public string LastName{
            get { return lastName; }
            set { lastName = value; }
        }
        public string Address{
            get { return address; }
            set { address = value; }
        }
        // you don't have to implement this.
        public virtual void Login()
        {
            Console.WriteLine("Employee Login");
        }
        public virtual void LogOff()
        {
            Console.WriteLine("Employee LogOff");
        }

        // you must implement this when you use it.  
        // you should not have a body here.
        public abstract void Hire();

    }

    class ManagerAbs : EmployeeAbs
    {
        //public override void Login()
        //{
        //    Console.WriteLine("Manager Login");
        //}
        public override void Hire()
        {
            Console.WriteLine("Hire Someone");
        }
        private string department;
    }
}
