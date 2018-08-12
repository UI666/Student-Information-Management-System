using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studentinfo
{
    public class Student
    {
        public string name;
        public decimal gpa;
        public Student(string s, decimal d)
        {
            name = s;
            gpa = d;
        }

        public void returnmane(string name, decimal gpa)
        {
            Console.WriteLine("Name of the studend who get Highest cgpa is {0} and its {1}", name, gpa);
            Console.ReadLine();
        }
    }
}
