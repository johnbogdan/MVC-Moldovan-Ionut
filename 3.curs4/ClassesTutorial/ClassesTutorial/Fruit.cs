using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesTutorial
{

    public class Fruit
    {
        public Fruit()
        {
            Console.WriteLine("The fruit has been created !");
        }
        public virtual int GetCalories()
        {
            return 1;
        }
        private class Sambure
        {

        }
    }
}
