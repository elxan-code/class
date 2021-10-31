using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Viecle
    {
        public string model;
        public string brend;
         public string color;
        public Viecle(string brend, string model,string color) 
        {
           this.brend = brend;
           this.model = model;
           this.color = color;
        }
    }
}
