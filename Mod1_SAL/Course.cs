using System;
using System.Collections;
using System.Collections.Generic;

namespace Mod1_SAL
{
    public class Course
    {
        public string Name { get; set; }
        public List<Student> Students = new List<Student>();
        public List<Teacher> Teachers = new List<Teacher>();

        public static int courseCount = 0;

        public Course()
        {
            courseCount++;
        }
        public Course(string name){
            this.Name = name;
            courseCount++;
        }
        public static int CountCourses(){
            return courseCount;
        }

    }
}
