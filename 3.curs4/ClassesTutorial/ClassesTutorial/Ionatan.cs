using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesTutorial
{
    class Ionatan : Apple
    {
        public Ionatan()
        {
            Console.WriteLine("The apple Ionatan has been created !");
        }

        public override int GetCalories()
        {
            return 3;
        }
    }
}
