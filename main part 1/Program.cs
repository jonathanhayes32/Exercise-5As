using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace main_part_1
{
    class Program
    {
        static void Main(string[] args)
        {

            sheep Joey = new sheep();

            Joey.speak("Joey", "Baaah");
            Console.ReadLine();


            chicken little = new chicken();

            little.speak("Little", "Cluck");
            Console.ReadLine();


            Goat billy = new Goat();

            billy.speak("Billy", "Bleat");
            Console.ReadLine();


            mouse cheese = new mouse();

            cheese.speak("Cheese", "Squeak");
            Console.ReadLine();
        }
    }
}
