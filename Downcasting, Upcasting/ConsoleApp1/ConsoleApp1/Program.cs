using System;

namespace ConsoleApp1
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Word word = new Word();
            Mainprintfile mainprintfile = word;
            mainprintfile.officle();
            Excel excel = new Excel();
            Mainprintfile mainprintfile1 = excel;
            mainprintfile1.officle();
                      
        }
    }
}
