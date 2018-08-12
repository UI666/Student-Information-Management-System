using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studentinfo
{
    class Program
    {
        public static void Main(string[] args)
        {

            Student s1 = new Student("babu", 3.52m);
            Student s2 = new Student("jon", 3.45m);
            Student s3 = new Student("rik", 2.84m);
            Student s4 = new Student("saj", 3.15m);

            decimal[] gpa_holder = new decimal[4];
            gpa_holder[0] = s1.gpa;
            gpa_holder[1] = s2.gpa;
            gpa_holder[2] = s3.gpa;
            gpa_holder[3] = s4.gpa;

            Array.Sort(gpa_holder);
            decimal judge = gpa_holder[3];
            if (s1.gpa == judge) s1.returnmane(s1.name, s1.gpa);
            else if (s2.gpa == judge) s2.returnmane(s2.name, s2.gpa);
            else if (s3.gpa == judge) s3.returnmane(s3.name, s3.gpa);
            else if (s4.gpa == judge) s4.returnmane(s4.name, s4.gpa);
        }
    }
}
