using System;
using System.Collections;
using System.Collections.Generic;

namespace Mod1_SAL
{
    public class Degree
    {
        public string Name { get; set; }
        public List<Course> Courses = new List<Course>();
        public static int degreeCount = 0;

        public Degree()
        {
            degreeCount++;
        }
        public Degree(string name){
            this.Name = name;
            degreeCount++;
        }

        public static int CountDegrees(){
            return degreeCount;
        }
    }
}
