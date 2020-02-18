using System;

namespace Boolean_Logic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age?");
            string age = Console.ReadLine();
            int ageInt = Int32.Parse(age);

            Console.WriteLine("\nHave you ever had a DUI?");
            string dui = Console.ReadLine();
            bool duiBool = bool.Parse(dui);
            Console.WriteLine(duiBool);

            Console.WriteLine("\nHow many speeding tickets do you have?");
            string tickets = Console.ReadLine();
            int ticketsInt = Int32.Parse(tickets);
            Console.WriteLine(ticketsInt);

            Console.WriteLine("\nQualified?");
            bool qualified = ageInt > 15 && duiBool == false && ticketsInt <= 3;
            Console.WriteLine(qualified);

            Console.ReadLine();

        }
    }
}
