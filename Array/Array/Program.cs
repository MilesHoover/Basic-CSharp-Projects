using System;
using System.Collections.Generic;

namespace Array
{
    class Program
    {
        static void Main()
        {
            string[] Cars = { "Ford", "Honda", "Hyundai", "Toyota" };
            Console.WriteLine("Select an index in an array with 4 different cars:\n");
            int indexCars = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Cars[indexCars]);

            int[] Years = { 2013, 2003, 2008, 2018 };
            Console.WriteLine("\nSelect an index in an array with 4 different years:\n");
            int indexYears = Convert.ToInt32(Console.ReadLine());
            if (indexYears >= 0 && indexYears <= 3)
            {
                Console.WriteLine(Years[indexYears]);
            }
            else
            {
                Console.WriteLine("\nYou must pick a value between 0 and 3!");
            }

            IList<string> Names = new List<string>();
            Names.Add("Helen");
            Names.Add("Rob");
            Names.Add("Dimitri");
            Names.Add("Juan");
            Console.WriteLine("\nSelect an index in the list with 4 different names:\n");
            int indexNames = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Names[indexNames]);

            Console.ReadLine();
        }
    }
}
