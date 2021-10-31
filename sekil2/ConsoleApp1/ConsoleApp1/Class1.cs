using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Student:Person
    {
        public string info()
        {

            return $"iam studing";

        }
        public string Info()
        {
            int a = 22;
            return $"my age is {a}";

        }

    }
}
