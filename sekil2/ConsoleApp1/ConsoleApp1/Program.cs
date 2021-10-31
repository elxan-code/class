using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Student stu = new Student();
            string stu1 = stu.info();
            Console.WriteLine(stu1);
            string stu2 = stu.Info();
            Console.WriteLine(stu2);
            Teacher tch = new Teacher();
            string tch1 = tch.INfO();
            Console.WriteLine(tch1);
          
        }
    }
}
