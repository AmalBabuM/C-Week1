using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Student_Age
{
    public class detail
    {
        public static void Main(string[] args)
        {   string search;
            List<student> detail= new List<student>();
            detail.Add(new student());
            detail[0].age=28;
            detail[0].name="amal";
            detail[0].department="science";

            detail.Add(new student());
            detail[1].age=23;
            detail[1].name="Rohit";
            detail[1].department="commerce";

            detail.Add(new student());
            detail[2].age=21;
            detail[2].name="Rahul";
            detail[2].department="Science";

            int flag=0;
            for(int i=0;i<detail.Count;i++)
            {
                if(detail[i].age>22)
                {
                    System.Console.WriteLine(detail[i].getdata());
                }
            }
            
            
        } 
    }
}