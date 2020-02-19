using System;
using System.Collections.Generic;
using System.Linq;

namespace Array_Iteration
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Miles", "Jacob", "Dawson" };
            Console.WriteLine("Please type a greeting:\n");
            string greeting = Console.ReadLine();
            foreach (string name in names)
            {
                Console.WriteLine(greeting + " " + name);
            }

            Console.ReadLine();

            bool infinite = true;
            while (infinite)
            {
                Console.WriteLine("This loop will be infinite if you keep pressing enter, type \"stop\" to stop");
                string stop = Console.ReadLine();
                if (stop == "stop")
                {
                    infinite = false;
                }
            }

            Console.ReadLine();

            for (int i=0; i<10; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("\nNotice how the loop ended on 9 because I used the \"<\" Operator");

            Console.ReadLine();

            for (int i = 0; i<=10; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("\nNotice how the loop ended on 10 because I used the \"<=\" Operator");

            Console.ReadLine();

            List<string> cars = new List<string>();
            cars.Add("ford");
            cars.Add("honda");
            cars.Add("toyota");
            Console.WriteLine("Search for a car name to get the index:\n");
            bool carUnSelected = true;
            do
            {
                string car = Console.ReadLine();
                if (cars.Contains(car))
                {
                    int carIndex = cars.BinarySearch(car);
                    Console.WriteLine("\nThe index was " + carIndex);
                    carUnSelected = false;
                }
                else
                {
                    Console.WriteLine("\nThat was not a car in the list, try again.");
                }
            } while (carUnSelected);

            Console.ReadLine();

            List<string> addresses = new List<string>();
            addresses.Add("Penny Drive");
            addresses.Add("Lakeside Avenue");
            addresses.Add("Penny Drive");
            addresses.Add("Waller Road");
            Console.WriteLine("Search for an address to get the index:\n");
            bool addyUnSelected = true;
            do
            {
                string address = Console.ReadLine();
                if (addresses.Contains(address))
                {
                    for (int i = 0; i < addresses.Count; i++)
                    {
                        if (address == addresses[i])
                        {
                            Console.WriteLine(i);
                        }                        
                    }
                    addyUnSelected = false;
                }                
                else
                {
                    Console.WriteLine("\nThat was not an address in the list, try again.");
                }
            } while (addyUnSelected);

            Console.ReadLine();

            List<string> colors = new List<string>();
            colors.Add("red");
            colors.Add("blue");
            colors.Add("green");
            colors.Add("yellow");
            colors.Add("purple");
            colors.Add("blue");
            var g = colors.GroupBy(i => i);
            foreach (var grp in g)
            {
                Console.WriteLine("The color is {0} and it has occured {1} time(s)", grp.Key, grp.Count());
            }
            Console.ReadLine();
        }
    }
}
