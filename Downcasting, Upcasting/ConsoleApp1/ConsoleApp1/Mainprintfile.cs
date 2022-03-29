using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    abstract class Mainprintfile : IPrintable
    {
        public void Print()
        {
            Console.WriteLine("d");
        }
        public abstract void officle();
    }
}
