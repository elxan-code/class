using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
           Student stu = new Student("Elxan","Texniki",4,"elxan789123@gmail.com","subject","055-777-9986");
            string stu1 = stu.info();
            
            Console.WriteLine(stu1);
            
            
        }
    }
}