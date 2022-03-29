using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class Group
    {
        public string No;
        public Student[] students;
        public int Studentlimit;

        public Student [] Addstudent(Student student)
        {
            Array.Resize(ref students, students.Length + 1);
            students[students.Length-1]=student;
            return students;
        }
    }
}
