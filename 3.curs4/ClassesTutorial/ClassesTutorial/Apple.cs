using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesTutorial
{
    class Apple : Fruit
    {
        public Apple()
        {
            Console.WriteLine("The apple has been created !");
        }
        public override int GetCalories()
        {
            return 2;
        }
    }
}
