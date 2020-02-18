using System;

namespace Income_Comparison
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Anonymous Income Comparison Program\n");

            Console.WriteLine("Person 1");
            Console.WriteLine("Hourly Rate?");
            string hRate = Console.ReadLine();
            decimal hRateInt = decimal.Parse(hRate);
            Console.WriteLine("Hours worked per weak?");
            string wHours = Console.ReadLine();
            int wHoursInt = Int32.Parse(wHours);

            Console.WriteLine("\nPerson 2");
            Console.WriteLine("Hourly Rate?");
            string hRate2 = Console.ReadLine();
            decimal hRateInt2 = decimal.Parse(hRate2);
            Console.WriteLine("Hours worked per weak?");
            string wHours2 = Console.ReadLine();
            Convert.ToInt32(wHours2);
            int wHoursInt2 = Int32.Parse(wHours2);

            Console.WriteLine("\nAnnual salary of Person 1");
            decimal person1 = ((52 * wHoursInt) * hRateInt);
            Console.WriteLine(person1);

            Console.WriteLine("\nAnnual salary of Person 2");
            decimal person2 = ((52 * wHoursInt2) * hRateInt2);
            Console.WriteLine(person2);

            Console.WriteLine("\nDoes Person 1 make more money than Person 2?");
            if (person1 > person2)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }

            Console.ReadLine();
        }  
    }
}
