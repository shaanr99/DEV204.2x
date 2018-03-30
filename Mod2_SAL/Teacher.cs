using System;
namespace Mod2_SAL
{
    class Teacher : Person
    {
        private String degree;
        public string Degree { get => degree; set => degree = value; }

        public Teacher(string fname, string lname) : base(fname, lname)
        {
        }
		public override string StateSomething()
		{
            return "The teacher (" + this.FirstName + ") is now stating something!";
		}
        public void GiveATest(string testName)
        {
            Console.WriteLine("The teacher is giving a test:  " + testName);
        }
	}
}
