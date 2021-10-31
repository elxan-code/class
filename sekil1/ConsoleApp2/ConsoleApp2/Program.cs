using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Car elxan = new Car("hundai","sonata","qara");

            string qayidan = elxan.info();
            Console.WriteLine(qayidan);
            string gelen = elxan.fullinfo();
            Console.WriteLine(gelen);
            Bicrycle viecle = new Bicrycle("bmx", "m60","white");
            string bilen = viecle.Info();
            Console.WriteLine(bilen);
            employe maas = new employe();
            string ozu = maas.INFO();
            Console.WriteLine(ozu);
        }
    }
}
