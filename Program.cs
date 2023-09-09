using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstConsoleApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var name = "Josué Benjamín Centurión";
            var location = "Resistencia, Arg. ";
            var Christmas = new DateTime(2023, 12, 23);
            var currentDate = DateTime.Now;
            var daysUntilChristmas = Christmas - currentDate;

            Console.WriteLine("My name is " + name + ", I'm from " + 
                location);
            Console.WriteLine(daysUntilChristmas.Days + 
                " days left until Christmas ");

            double width, height, woodLength, glassArea;
            string widthString, heightString;

            Console.WriteLine("Write the width of the Window: ");
            widthString = Console.ReadLine();
            width = double.Parse(widthString);

            Console.WriteLine("Write the height of the Window: ");
            heightString = Console.ReadLine();
            height = double.Parse(heightString);

            woodLength = 2 * (width + height) * 3.25;
            glassArea = 2 * (width * height);

            Console.WriteLine("The length of the wood is " +
            woodLength + " feet");
            Console.WriteLine("The area of the glass is " +
            glassArea + " square metres");

            Console.ReadKey();

        }
    }
}
