using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Bicrycle: Viecle
    {
       // string model;
        //string brend;
        //string color;
        string wheelsize;

        public Bicrycle(string brend, string model,string color) : base(brend,model,color)
    {
             {
                
            }
        }
        public string Info()
        {
        return $"{brend},{model}";
    }
}
}
