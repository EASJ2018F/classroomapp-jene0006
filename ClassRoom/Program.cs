using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            KlasseRum rum = new KlasseRum();
            
            Studerende f1 = new Studerende("Jenees Gunatheeswaran", 9,26);
            Studerende f2 = new Studerende("Hassan Raza Hussain",4,15);
            Studerende f3 = new Studerende("Ahmed Metin Dönmez Aka Chad",8,29);

            //rum.SemesterStart = DateTime.Parse(" 08:28:2017 ");
            rum.ClassName = "3F";

            rum.ClassList.Add(f1);
            rum.ClassList.Add(f2);
            rum.ClassList.Add(f3);

            Console.WriteLine("Klassens navn er:");
            Console.WriteLine(rum.ClassName);
            Console.WriteLine("");
            Console.WriteLine("Semesteret har opstart på følgende dato:");
            Console.WriteLine(rum.SemesterStart);
            Console.WriteLine("");
            Console.WriteLine("Klassens elever er følgende:");

            foreach (var Studerende in rum.ClassList)
            {
               Console.WriteLine(Studerende);
            }

            Console.WriteLine("");
            Console.WriteLine("Antallet af elver der har fødselsdag i hver årstid er:");
            rum.Seasons();
            Console.ReadKey();
        }
    }
}

