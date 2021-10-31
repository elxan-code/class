using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Size
    {
        string width;
        string lenght;
        string height;

        public string info()
        {

            int a, b, c,d;
            a=Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());
            d = a * b * c;
            return $" VolumeofBox (width:{a},lenght:{b},height:{c})>{d}";

        }

    }
}
