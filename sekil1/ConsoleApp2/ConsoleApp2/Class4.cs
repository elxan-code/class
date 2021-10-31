using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class employe
    {
        string name;
        string surname;
        string position;
        string dailysalary;

        public string INFO()
        {
            int a=30, b=31, c;
            c = b *a;
            return $"dailysalary is {c}";
        }
    }
}
