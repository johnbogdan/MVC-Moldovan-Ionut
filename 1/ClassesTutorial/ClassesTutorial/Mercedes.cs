﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesTutorial
{
    // Exercise 2 course 2
    public class Mercedes : AbstractCar
    {
        // Exercise 6 slide 20 course 2
        public string description;
        public int price;

        public Mercedes(int n)
        {

        }

        // Exercise 6 slide 18 course 2
        public Mercedes()
        {
            Description = "E Class";
            Price = 67000;

            Putere = 170;
            Transmisie = "Manuala";

            Consum = 8;
            Model = "Sport";

        }

        // Exercise 8 slide 25 course 2
        public string Description
        {
            get
            {
                return description;
            }

            set
            {
                description = value;
            }
        }

        public int Price
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
            }
        }

        // Exercise 9 slide 27 course 2
        protected int putere;
        protected string transmisie;

        protected int Putere
        {
            get
            {
                return putere;
            }
            set
            {
                putere = value;
            }
        }

        protected string Transmisie
        {
            get
            {
                return transmisie;
            }
            set
            {
                transmisie = value;
            }
        }

        internal int consum;
        internal string model;

        internal int Consum
        {
            get
            {
                return consum;
            }
            set
            {
                consum = value;
            }
        }
        internal string Model
        {
            get
            {
                return model;
            }
            set
            {
                model = value;
            }
        }

        public void PrintMercedeLogo()
        {

            Console.WriteLine("Mercedes");
        }

        public void PrintMercedesLogo2(int count)
        {
            count++;
            Console.WriteLine("Mercedes");
            if (count == 3)
                return;
        }

        public void PrintMercedes(int c)
        {
            if (c == 3)
                return;
            Console.WriteLine("Mercedes");
        }

    }
}

