using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesTutorial
{
    class FruitBasket
    {
        private List<Fruit> ListaDeFructe;

        public FruitBasket()
        {
            ListaDeFructe = new List<Fruit>();
        }

        public void addFruct(Fruit fruct)// polimorfism
        {
            ListaDeFructe.Add(fruct);
        }
        public void displayFruitCalories()
        {
            foreach (var f in ListaDeFructe)
            {
                Console.WriteLine(f);
            }
        }
    }
}
