using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Student_Age
{
    public class student
    {
        public int age;
        public string name;
        public string department;

        public string getdata()
        {
            return this.age + " : " + this.name + " : " + this.department;
        } 
    }
}