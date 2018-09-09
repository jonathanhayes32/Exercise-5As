using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace main_part_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //build a farm
            Mouse Cheryll = new Mouse();
            Chicken Martha = new Chicken();
            Goat Spot = new Goat();
            Sheep Beatrice = new Sheep();

            Console.WriteLine("Hello and welcome to my farm!");
            Console.WriteLine("Let me introduce you to our animals");
            Console.WriteLine();
        }

        private class Mouse
        {
            public Mouse()
            {
            }
        }

        private class Chicken
        {
            public Chicken()
            {
            }
        }

        private class Goat
        {
            public Goat()
            {
            }
        }

        private class Sheep
        {
            public Sheep()
            {
            }
        }
    }
}
