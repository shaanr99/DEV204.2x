using System;
using System.Collections;
using System.Collections.Generic;

namespace Mod1_SAL
{
    public class UProgram
    {
        public string Name { get; set; }
        public List<Degree> Degrees = new List<Degree>();
        public static int degreeCount = 0;

        public UProgram()
        {
            degreeCount++;
        }
        public UProgram(string name){
            this.Name = name;
            degreeCount++;
        }
        public static int CountDegrees(){
            return degreeCount;
        }
    }
}
