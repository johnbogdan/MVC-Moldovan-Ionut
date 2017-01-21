using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exercise 1 course 2
            Console.WriteLine("This is my first C# project.");

            //AbstractCar aCar = new AbstractCar();

            //EngineStruct engine = new EngineStruct();

            //Exercise 6 course 2
            ICar car = new Mercedes();
            AbstractCar car2 = new Mercedes();

            // Exercise 7 slide 21 course 2
            Mercedes _mercedes = new Mercedes();

            Console.WriteLine("Mercedes is " + _mercedes.Description);
            Console.WriteLine("Mercedes costs " + _mercedes.Price);

            Console.WriteLine("Model " + _mercedes.Model);
            Console.WriteLine("Consum " + _mercedes.Consum);

        }
    }
}
