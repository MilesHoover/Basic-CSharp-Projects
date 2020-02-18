using System;

namespace Branching
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            Console.WriteLine("\nPlease enter the package weight:");
            string weight = Console.ReadLine();
            int weightInt = Int32.Parse(weight);
            if (weightInt > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                Console.ReadLine();
                System.Environment.Exit(0);
            }

            Console.WriteLine("\nPlease enter the package width:");
            string width = Console.ReadLine();
            int widthInt = Int32.Parse(width);

            Console.WriteLine("\nPlease enter the package height");
            string height = Console.ReadLine();
            int heightInt = Int32.Parse(height);

            Console.WriteLine("\nPlease enter the package length");
            string length = Console.ReadLine();
            int lengthInt = Int32.Parse(length);

            if ((widthInt + heightInt + lengthInt) > 50)
            {
                Console.WriteLine("\nPackage too big to be shipped via Package Express.");
                Console.ReadLine();
                System.Environment.Exit(0);
            }

            decimal quote = (widthInt * heightInt * lengthInt * weightInt) / 100m;

            Console.WriteLine("\nYour estimated total for shipping this package is: $" + quote + "\nThank You");
            Console.ReadLine();
        }
    }
}
