using System;
namespace Mod2_SAL
{
    abstract class Person
    {
        private String firstName;
        private String lastName;
        private int personID;
        private static int personCount = 1;

        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public int ID { get => personID; set => personID = value; }

        public Person(String first, String last)
        {
            this.firstName = first;
            this.lastName = last;
            this.ID = personCount++;
        }

        public virtual String getName()
        {
            return this.firstName + " " + this.lastName;
        }

        public int getID()
        {
            return this.ID;
        }

        public abstract String StateSomething();
    }
}
