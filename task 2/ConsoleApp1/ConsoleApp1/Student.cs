using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class Student
    {
        public string Fullname;
        public string Groupeno;
        public int Avgpoint;

        public Student(string fullname)
        {
            
            Fullname = fullname;
           
        }

        public  void fullname()
        {
            Console.WriteLine(Fullname);
        }

    }
}
