using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Qurup adini daxil edin :2 boyuk herif 3 reqem olmalidir");
            string groupno = Console.ReadLine();
            while (!(groupno.Length == 5 && char.IsUpper(groupno[0]) && char.IsUpper(groupno[1]) && char.IsDigit(groupno[2]) && char.IsDigit(groupno[3])))
            {
                Console.WriteLine("Qurup adini daxil edin :2 boyuk herif 3 reqem olmalidir");
                groupno = Console.ReadLine();
            }
            Console.WriteLine("Qurupa max telebe limitin daxil edin 0-20arasi");
            int gropelimit = Convert.ToInt32(Console.ReadLine());
            while (!(gropelimit > 0 && gropelimit < 20))
            {
                Console.WriteLine("Qurupa max telebe limitin daxil edin 0 - 20arasi");
                gropelimit = Convert.ToInt32(Console.ReadLine());

            }
            Student student = new Student("ASLANOV MURAD");

            string name;
            Console.WriteLine("1  ad soyad");
            Console.WriteLine("2  group");
            Console.WriteLine("3  butun melumatlar");
            Console.WriteLine("0  EXT");
            int number;
            do
            {
                
                number = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("1   Ad soyadivizi daxil edin");               
                student.fullname();
                Console.WriteLine("2   GROUPNO");
                name = Console.ReadLine();
                Console.WriteLine(groupno);
                Console.WriteLine("3   BUTUN MELUMATLAR");
                name = Console.ReadLine();
                Console.WriteLine($"{groupno}\n{gropelimit}\n{student.Fullname}\n");
                

            } while (number != 0);







        }
    }
}
