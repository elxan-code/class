using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Student
    {
        string fullname;
        byte course;
        string subject;
        string universitety;
        string email;
        string PhoneNumber ;
        public Student (string fullname, string universitety, byte course,string email,string PhoneNumber,string subject)
        {
          this.fullname = fullname;
           this.course = course;
           this.universitety = universitety;
            this.email = email;
            this.PhoneNumber = PhoneNumber;
            this.subject = subject;
        }
        
        public string info ()
        {

            return $"{fullname} {universitety} {course} {subject} {email} {PhoneNumber}";
        }
    }
}
