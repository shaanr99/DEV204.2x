using System;

namespace Mod2_OOPS
{
    class Program
    {
        static void Main(string[] args)
        {
            Manager m = new Manager();
            m.FirstName = "John";
            m.LastName = "Doe";

            // Notice that the private members in the Manager class
            // are not visible.

            // now use an abstract class
            ManagerAbs managerAbs = new ManagerAbs();
            managerAbs.Login();

        }
    }
}
