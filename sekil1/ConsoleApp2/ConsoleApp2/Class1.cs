using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Car: Viecle
    {
       // string model;
        //string brend;
      // string color;
        string fullcapasity;
        string doorcount;
        string consumption;


        public Car(string brend, string model,string color) : base(brend,model,color)
        {
            {
                 
            }
        }
        public string info()
        {
            return $"{brend},{model},{color}";
        }
        public string fullinfo()
        {
            float a = 40,b=0.5f,c;
            c=a/b;
            return $"polnu bakla {c} km yol gede biler";

        }


    }
   
}
