using System;

namespace Classes_5
{
    class Program
    {
        static void Main(string[] args)
        {

            Operations n = new Operations();

            Console.WriteLine("Please type an integer to be divided by 2:");
            int num = Convert.ToInt32(Console.ReadLine());
            n.Div(num);

            Console.ReadLine();

            n.Greeting();

            Console.ReadLine();

            Console.WriteLine("Please type an integer to be multiplied by 5:");
            int numMult = Convert.ToInt32(Console.ReadLine());
            int callMult;
            callMult = n.stringOrInt(numMult);
            Console.WriteLine(callMult);

            Console.ReadLine();

            Console.WriteLine("Please type a name: ");
            string nameGreet = Console.ReadLine();
            string callGreet;
            callGreet = n.stringOrInt(nameGreet);
            Console.WriteLine(callGreet);

            Console.ReadLine();

            Operations.withoutObj();

            Console.ReadKey();

        }
    }
}
